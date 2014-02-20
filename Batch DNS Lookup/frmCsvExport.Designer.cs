namespace ClandestineDevelopment.Tools.BatchDnsLookup
{
    partial class frmCsvExport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbDomainsAndResults = new System.Windows.Forms.RadioButton();
            this.rbResultsOnly = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDelimiterOtherChar = new System.Windows.Forms.TextBox();
            this.rbDelimiterOther = new System.Windows.Forms.RadioButton();
            this.rbDelimiterTab = new System.Windows.Forms.RadioButton();
            this.rbDelimeterSemicolon = new System.Windows.Forms.RadioButton();
            this.rbDelimeterComma = new System.Windows.Forms.RadioButton();
            this.chkIncludeHeaders = new System.Windows.Forms.CheckBox();
            this.chkEmbedInDoubleQuotes = new System.Windows.Forms.CheckBox();
            this.btnExportFile = new System.Windows.Forms.Button();
            this.btnExportClipboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDomainsAndResults
            // 
            this.rbDomainsAndResults.AutoSize = true;
            this.rbDomainsAndResults.Checked = true;
            this.rbDomainsAndResults.Location = new System.Drawing.Point(6, 19);
            this.rbDomainsAndResults.Name = "rbDomainsAndResults";
            this.rbDomainsAndResults.Size = new System.Drawing.Size(120, 17);
            this.rbDomainsAndResults.TabIndex = 0;
            this.rbDomainsAndResults.TabStop = true;
            this.rbDomainsAndResults.Text = "Domains and results";
            this.rbDomainsAndResults.UseVisualStyleBackColor = true;
            // 
            // rbResultsOnly
            // 
            this.rbResultsOnly.AutoSize = true;
            this.rbResultsOnly.Location = new System.Drawing.Point(6, 42);
            this.rbResultsOnly.Name = "rbResultsOnly";
            this.rbResultsOnly.Size = new System.Drawing.Size(82, 17);
            this.rbResultsOnly.TabIndex = 1;
            this.rbResultsOnly.Text = "Results only";
            this.rbResultsOnly.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbResultsOnly);
            this.groupBox1.Controls.Add(this.rbDomainsAndResults);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose which data to export";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDelimiterOtherChar);
            this.groupBox2.Controls.Add(this.rbDelimiterOther);
            this.groupBox2.Controls.Add(this.rbDelimiterTab);
            this.groupBox2.Controls.Add(this.rbDelimeterSemicolon);
            this.groupBox2.Controls.Add(this.rbDelimeterComma);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose a delimiter";
            // 
            // txtDelimiterOtherChar
            // 
            this.txtDelimiterOtherChar.Enabled = false;
            this.txtDelimiterOtherChar.Location = new System.Drawing.Point(132, 41);
            this.txtDelimiterOtherChar.MaxLength = 1;
            this.txtDelimiterOtherChar.Name = "txtDelimiterOtherChar";
            this.txtDelimiterOtherChar.Size = new System.Drawing.Size(24, 20);
            this.txtDelimiterOtherChar.TabIndex = 4;
            // 
            // rbDelimiterOther
            // 
            this.rbDelimiterOther.AutoSize = true;
            this.rbDelimiterOther.Location = new System.Drawing.Point(72, 42);
            this.rbDelimiterOther.Name = "rbDelimiterOther";
            this.rbDelimiterOther.Size = new System.Drawing.Size(54, 17);
            this.rbDelimiterOther.TabIndex = 3;
            this.rbDelimiterOther.TabStop = true;
            this.rbDelimiterOther.Text = "Other:";
            this.rbDelimiterOther.UseVisualStyleBackColor = true;
            this.rbDelimiterOther.CheckedChanged += new System.EventHandler(this.rbDelimiterOther_CheckedChanged);
            // 
            // rbDelimiterTab
            // 
            this.rbDelimiterTab.AutoSize = true;
            this.rbDelimiterTab.Location = new System.Drawing.Point(6, 42);
            this.rbDelimiterTab.Name = "rbDelimiterTab";
            this.rbDelimiterTab.Size = new System.Drawing.Size(44, 17);
            this.rbDelimiterTab.TabIndex = 2;
            this.rbDelimiterTab.Text = "Tab";
            this.rbDelimiterTab.UseVisualStyleBackColor = true;
            // 
            // rbDelimeterSemicolon
            // 
            this.rbDelimeterSemicolon.AutoSize = true;
            this.rbDelimeterSemicolon.Location = new System.Drawing.Point(72, 19);
            this.rbDelimeterSemicolon.Name = "rbDelimeterSemicolon";
            this.rbDelimeterSemicolon.Size = new System.Drawing.Size(74, 17);
            this.rbDelimeterSemicolon.TabIndex = 1;
            this.rbDelimeterSemicolon.Text = "Semicolon";
            this.rbDelimeterSemicolon.UseVisualStyleBackColor = true;
            // 
            // rbDelimeterComma
            // 
            this.rbDelimeterComma.AutoSize = true;
            this.rbDelimeterComma.Checked = true;
            this.rbDelimeterComma.Location = new System.Drawing.Point(6, 19);
            this.rbDelimeterComma.Name = "rbDelimeterComma";
            this.rbDelimeterComma.Size = new System.Drawing.Size(60, 17);
            this.rbDelimeterComma.TabIndex = 0;
            this.rbDelimeterComma.TabStop = true;
            this.rbDelimeterComma.Text = "Comma";
            this.rbDelimeterComma.UseVisualStyleBackColor = true;
            // 
            // chkIncludeHeaders
            // 
            this.chkIncludeHeaders.AutoSize = true;
            this.chkIncludeHeaders.Location = new System.Drawing.Point(18, 160);
            this.chkIncludeHeaders.Name = "chkIncludeHeaders";
            this.chkIncludeHeaders.Size = new System.Drawing.Size(102, 17);
            this.chkIncludeHeaders.TabIndex = 2;
            this.chkIncludeHeaders.Text = "Include headers";
            this.chkIncludeHeaders.UseVisualStyleBackColor = true;
            // 
            // chkEmbedInDoubleQuotes
            // 
            this.chkEmbedInDoubleQuotes.AutoSize = true;
            this.chkEmbedInDoubleQuotes.Location = new System.Drawing.Point(18, 183);
            this.chkEmbedInDoubleQuotes.Name = "chkEmbedInDoubleQuotes";
            this.chkEmbedInDoubleQuotes.Size = new System.Drawing.Size(164, 17);
            this.chkEmbedInDoubleQuotes.TabIndex = 3;
            this.chkEmbedInDoubleQuotes.Text = "Embed data in double quotes";
            this.chkEmbedInDoubleQuotes.UseVisualStyleBackColor = true;
            // 
            // btnExportFile
            // 
            this.btnExportFile.Location = new System.Drawing.Point(29, 219);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(65, 23);
            this.btnExportFile.TabIndex = 4;
            this.btnExportFile.Text = "File";
            this.btnExportFile.UseVisualStyleBackColor = true;
            this.btnExportFile.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExportClipboard
            // 
            this.btnExportClipboard.Location = new System.Drawing.Point(100, 219);
            this.btnExportClipboard.Name = "btnExportClipboard";
            this.btnExportClipboard.Size = new System.Drawing.Size(65, 23);
            this.btnExportClipboard.TabIndex = 5;
            this.btnExportClipboard.Text = "Clipboard";
            this.btnExportClipboard.UseVisualStyleBackColor = true;
            this.btnExportClipboard.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Export to:";
            // 
            // frmCsvExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(195, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportClipboard);
            this.Controls.Add(this.btnExportFile);
            this.Controls.Add(this.chkEmbedInDoubleQuotes);
            this.Controls.Add(this.chkIncludeHeaders);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCsvExport";
            this.Text = "Export to CSV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDomainsAndResults;
        private System.Windows.Forms.RadioButton rbResultsOnly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDelimiterTab;
        private System.Windows.Forms.RadioButton rbDelimeterSemicolon;
        private System.Windows.Forms.RadioButton rbDelimeterComma;
        private System.Windows.Forms.CheckBox chkIncludeHeaders;
        private System.Windows.Forms.CheckBox chkEmbedInDoubleQuotes;
        private System.Windows.Forms.Button btnExportFile;
        private System.Windows.Forms.Button btnExportClipboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDelimiterOtherChar;
        private System.Windows.Forms.RadioButton rbDelimiterOther;
    }
}