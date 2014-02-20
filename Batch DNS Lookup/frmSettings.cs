using System;
using System.Windows.Forms;
using ClandestineDevelopment.Tools.BatchDnsLookup.Properties;

namespace ClandestineDevelopment.Tools.BatchDnsLookup
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            numDnsQueryTimeout.Value = Settings.Default.DnsQueryTimeout;
            numDnsQueryRetries.Value = Settings.Default.DnsQueryRetryCount;
            chkEnableThreading.Checked = Settings.Default.EnableThreading;
            chkEnableCustomDnsServers.Checked = Settings.Default.EnableCustomDnsServers;
            txtCustomDnsServer1.Text = Settings.Default.PrimaryDnsServer;
            txtCustomDnsServer2.Text = Settings.Default.SecondaryDnsServer;
            chkEnableDebugLogging.Checked = Settings.Default.EnableDebugLogging;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Settings.Default.DnsQueryTimeout = numDnsQueryTimeout.Value;
            Settings.Default.DnsQueryRetryCount = numDnsQueryRetries.Value;
            Settings.Default.EnableThreading = chkEnableThreading.Checked;
            Settings.Default.EnableCustomDnsServers = chkEnableCustomDnsServers.Checked;
            Settings.Default.PrimaryDnsServer = txtCustomDnsServer1.Text;
            Settings.Default.SecondaryDnsServer = txtCustomDnsServer2.Text;
            Settings.Default.EnableDebugLogging = chkEnableDebugLogging.Checked;
            Settings.Default.Save();
        }
    }
}
