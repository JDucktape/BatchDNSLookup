using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

using ClandestineDevelopment.Tools.BatchDnsLookup.Properties;
using JHSoftware;
using System.Text;

namespace ClandestineDevelopment.Tools.BatchDnsLookup
{
    public enum DnsRecordType { A, AAAA, ANY, CNAME, MX, NS, PTR, SOA, SPF, SRV, TXT }

    public partial class frmMain : Form
    {
        IPAddress PrimaryDnsServer;
        IPAddress SecondaryDnsServer;
        DnsLookup LookupTool;
        List<DnsDataItem> domains = new List<DnsDataItem>();
        DnsClient.RecordType selectedRecordType;
        int workCounter = 0;
        bool useDebugLogging = false;
        private bool keyHandled;

        public frmMain()
        {
            InitializeComponent();
            cmbRecordType.DataSource = Enum.GetValues(typeof(DnsRecordType));
        }

        private bool InitializeCustomDnsServers()
        {
            bool status = true;
            if (Settings.Default.EnableCustomDnsServers)
            {
                Log("Initializing custom DNS servers", true);
                if (Settings.Default.PrimaryDnsServer.Length > 0 || Settings.Default.SecondaryDnsServer.Length > 0)
                {
                    bool parseResult = IPAddress.TryParse(Settings.Default.PrimaryDnsServer, out PrimaryDnsServer);
                    if (parseResult == false)
                    {
                        // Couldn't parse dns server, it must be a hostname.
                        try
                        {
                            IPAddress[] servers = Dns.GetHostAddresses(Settings.Default.PrimaryDnsServer);
                            if (servers.Length >= 1)
                            {
                                PrimaryDnsServer = servers[0];
                            }
                            else
                            {
                                MessageBox.Show("Unable to lookup primary DNS server.", "Error");
                                Log("Unable to lookup primary DNS server", true);
                                status = false;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Unable to lookup primary DNS server.", "Error");
                            Log("Unable to lookup primary DNS server", true);
                            status = false;
                        }
                    }
                    parseResult = IPAddress.TryParse(Settings.Default.SecondaryDnsServer, out SecondaryDnsServer);
                    if (parseResult == false)
                    {
                        // Couldn't parse dns server, it must be a hostname.
                        try
                        {
                            IPAddress[] servers = Dns.GetHostAddresses(Settings.Default.SecondaryDnsServer);
                            if (servers.Length >= 1)
                            {
                                SecondaryDnsServer = servers[0];
                            }
                            else
                            {
                                MessageBox.Show("Unable to lookup secondary DNS server.", "Error");
                                Log("Unable to lookup secondary DNS server", true);
                                status = false;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Unable to lookup secondary DNS server.", "Error");
                            Log("Unable to lookup secondary DNS server", true);
                            status = false;
                        }
                    }
                }
                else
                {
                    status = false;
                    MessageBox.Show("Please define both custom DNS servers", "Error");
                }
            }
            if (status)
            {
                LookupTool.PrimaryDnsServer = PrimaryDnsServer;
                LookupTool.SecondaryDnsServer = SecondaryDnsServer;
            }
            return status;
        }

        private void Log(string text)
        {
            Log(text, false);
        }

        private void Log(string text, bool isDebugMessage)
        {
            if (txtOutput.InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(delegate() { Log(text, isDebugMessage); }));
            }
            else
            {
                if ((isDebugMessage && useDebugLogging) || !isDebugMessage)
                {
                    txtOutput.AppendText(text + Environment.NewLine);
                    txtOutput.ScrollToCaret();
                }
            }
        }

        private void IncreaseProgress()
        {
            if (prgProgress.ProgressBar.InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(delegate() { IncreaseProgress(); }));
            }
            else
            {
                prgProgress.Increment(1);
            }
        }

        private void UpdateStatusBar()
        {
            lblStatus.Text = String.Format("Looking up domain {0} of {1}...", prgProgress.Value, txtInput.Lines.Length);
        }
        
        private void DoThreadedLookup(object dataitem)
        {
            DnsDataItem item = (DnsDataItem)dataitem;
            item.Result = LookupTool.Lookup(item.Domain, selectedRecordType, chkOnlyOneRecord.Checked);
            IncreaseProgress();
            workCounter++;
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            LookupTool = new DnsLookup(Settings.Default.EnableCustomDnsServers, Settings.Default.EnableDebugLogging, (int)Settings.Default.DnsQueryTimeout, (int)Settings.Default.DnsQueryRetryCount);

            useDebugLogging = Settings.Default.EnableDebugLogging;

            // Disable the GUI so we don't get interrupted
            btnLookup.Enabled = false;
            txtInput.Enabled = false;
            txtOutput.Enabled = false;
            txtOutput.Clear();

            // Reset the progress bar
            prgProgress.Maximum = txtInput.Lines.Length;
            prgProgress.Minimum = 0;
            prgProgress.Value = prgProgress.Minimum;

            // Initialize custom DNS servers if they are used
            if (!InitializeCustomDnsServers())
            {
                MessageBox.Show("Unable to initialize custom DNS servers." + Environment.NewLine + "Change the servers or disable the feature and try again.", "Error");
                Log("Unable to initalize custom DNS servers");
            }
            else
            {
                // Start looking up domains
                DateTime startTime = DateTime.Now;
                selectedRecordType = (DnsClient.RecordType)Enum.Parse(typeof(DnsClient.RecordType), cmbRecordType.SelectedValue.ToString());

                domains.Clear();
                workCounter = 0;
                for (int i = 0; i < txtInput.Lines.Length; i++)
                {
                    domains.Add(new DnsDataItem(i, txtInput.Lines[i]));
                }

                if (Settings.Default.EnableThreading)
                {
                    Log("Multithreaded queries enabled. Queing domains in ThreadPool", true);
                    foreach (var d in domains)
                    {
                        ThreadPool.QueueUserWorkItem(this.DoThreadedLookup, d);
                    }
                    while (workCounter < domains.Count)
                    {
                        if (workCounter > 0)
                        {
                            if (workCounter % 10 == 0)
                            {
                                // Update GUI for every 10 domains processed
                                UpdateStatusBar();
                                Application.DoEvents();
                            }
                        }
                    }
                }
                else
                {
                    foreach (var d in domains)
                    {
                        d.Result = LookupTool.Lookup(d.Domain, selectedRecordType, chkOnlyOneRecord.Checked);
                        IncreaseProgress();
                        UpdateStatusBar();
                    }
                }

                DateTime endTime = DateTime.Now;
                lblStatus.Text = String.Format("Total query time for {0} domains: {1}", txtInput.Lines.Length, (endTime - startTime));
                Log(String.Format("Total query time for {0} domains: {1}", txtInput.Lines.Length, (endTime - startTime)), true);

                foreach (var d in domains)
                {
                    Log(d.Result);
                }                
            }

            // Enable the GUI again
            txtOutput.Enabled = true;
            txtInput.Enabled = true;
            btnLookup.Enabled = true;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings();
            settings.ShowDialog();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtInput.SelectAll();
                keyHandled = true;
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (keyHandled)
            {
                e.Handled = true;
                keyHandled = false;
            }
        }

        private void txtOutput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtOutput.SelectAll();
                keyHandled = true;
            }
        }

        private void txtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (keyHandled)
            {
                e.Handled = true;
                keyHandled = false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCsvExport exporter = new frmCsvExport();
            if (exporter.ShowDialog() == DialogResult.OK)
            {
                string data = GetCsvExportData(exporter);
                if (data.Length == 0)
                {
                    MessageBox.Show("No data to export!", "Error");
                }
                else
                {
                    if (exporter.ExportToClipboard)
                    {
                        Clipboard.SetText(GetCsvExportData(exporter));
                        MessageBox.Show("The data is now available in the clipboard.");
                    }
                    else
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.AddExtension = true;
                        sfd.DefaultExt = ".csv";
                        sfd.Filter = "CSV (Comma separated) (*.csv)|*.csv|All files (*.*)|*.*";
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                using (StreamWriter sw = new StreamWriter(sfd.OpenFile()))
                                {
                                    sw.Write(GetCsvExportData(exporter));
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error exporting data!" + Environment.NewLine + ex.Message, "Error");
                            }
                        }
                    }
                }
            }
        }

        private string GetCsvExportData(frmCsvExport exporter) 
        {
            StringBuilder sb = new StringBuilder();
            if (exporter.IncludeHeaders)
            {
                string headerDomain = "Domain";
                string headerResult = "Results";

                if (exporter.ExportAllData)
                {
                    if (exporter.EmbedInDoubleQuotes)
                    {
                        sb.AppendLine(String.Format("\"{0}\"{1}\"{2}\"", headerDomain, exporter.Delimiter, headerResult));
                    }
                    else
                    {
                        sb.AppendLine(String.Format("{0}{1}{2}", headerDomain, exporter.Delimiter, headerResult));
                    }
                }
                else
                {
                    if (exporter.EmbedInDoubleQuotes)
                    {
                        sb.AppendLine(String.Format("\"{0}\"", headerResult));
                    }
                    else
                    {
                        sb.AppendLine(headerResult);
                    }
                }
            }
            foreach (var d in domains)
            {
                if (exporter.ExportAllData)
                {
                    sb.AppendLine(d.GetDomainAndResultAsCSV(exporter.EmbedInDoubleQuotes, exporter.Delimiter));
                }
                else
                {
                    sb.AppendLine(d.GetResultsAsCSV(exporter.EmbedInDoubleQuotes));
                }
            }
            return sb.ToString();
        }
    }
}
