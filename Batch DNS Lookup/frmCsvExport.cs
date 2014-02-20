using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClandestineDevelopment.Tools.BatchDnsLookup
{
    public partial class frmCsvExport : Form
    {
        public bool ExportAllData { get; private set; }
        public char Delimiter { get; private set; }
        public bool IncludeHeaders { get; private set; }
        public bool EmbedInDoubleQuotes { get; private set; }
        public bool ExportToClipboard { get; private set; }

        public frmCsvExport()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportAllData = rbDomainsAndResults.Checked;
            IncludeHeaders = chkIncludeHeaders.Checked;
            EmbedInDoubleQuotes = chkEmbedInDoubleQuotes.Checked;
            if (rbDelimeterComma.Checked)
            {
                Delimiter = ',';
            }
            else if (rbDelimeterSemicolon.Checked)
            {
                Delimiter = ';';
            }
            else if (rbDelimiterTab.Checked)
            {
                Delimiter = '\t';
            }
            else if (rbDelimiterOther.Checked)
            {
                Delimiter = Convert.ToChar(txtDelimiterOtherChar.Text);
            }
            if ((sender as Button) == btnExportClipboard)
            {
                ExportToClipboard = true;
            }
            else
            {
                ExportToClipboard = false;
            }
            DialogResult = DialogResult.OK;
        }

        private void rbDelimiterOther_CheckedChanged(object sender, EventArgs e)
        {
            txtDelimiterOtherChar.Enabled = rbDelimiterOther.Checked;
        }
    }
}
