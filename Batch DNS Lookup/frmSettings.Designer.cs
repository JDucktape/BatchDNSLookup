namespace ClandestineDevelopment.Tools.BatchDnsLookup
{
    partial class frmSettings
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
            this.chkEnableCustomDnsServers = new System.Windows.Forms.CheckBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnCancelSettings = new System.Windows.Forms.Button();
            this.txtCustomDnsServer1 = new System.Windows.Forms.TextBox();
            this.txtCustomDnsServer2 = new System.Windows.Forms.TextBox();
            this.chkEnableDebugLogging = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEnableThreading = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numDnsQueryTimeout = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numDnsQueryRetries = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numDnsQueryTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDnsQueryRetries)).BeginInit();
            this.SuspendLayout();
            // 
            // chkEnableCustomDnsServers
            // 
            this.chkEnableCustomDnsServers.AutoSize = true;
            this.chkEnableCustomDnsServers.Location = new System.Drawing.Point(12, 82);
            this.chkEnableCustomDnsServers.Name = "chkEnableCustomDnsServers";
            this.chkEnableCustomDnsServers.Size = new System.Drawing.Size(159, 17);
            this.chkEnableCustomDnsServers.TabIndex = 0;
            this.chkEnableCustomDnsServers.Text = "Enable custom DNS servers";
            this.chkEnableCustomDnsServers.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveSettings.Location = new System.Drawing.Point(12, 180);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 1;
            this.btnSaveSettings.Text = "&Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnCancelSettings
            // 
            this.btnCancelSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelSettings.Location = new System.Drawing.Point(203, 180);
            this.btnCancelSettings.Name = "btnCancelSettings";
            this.btnCancelSettings.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSettings.TabIndex = 2;
            this.btnCancelSettings.Text = "&Cancel";
            this.btnCancelSettings.UseVisualStyleBackColor = true;
            // 
            // txtCustomDnsServer1
            // 
            this.txtCustomDnsServer1.Location = new System.Drawing.Point(140, 105);
            this.txtCustomDnsServer1.Name = "txtCustomDnsServer1";
            this.txtCustomDnsServer1.Size = new System.Drawing.Size(138, 20);
            this.txtCustomDnsServer1.TabIndex = 3;
            // 
            // txtCustomDnsServer2
            // 
            this.txtCustomDnsServer2.Location = new System.Drawing.Point(140, 131);
            this.txtCustomDnsServer2.Name = "txtCustomDnsServer2";
            this.txtCustomDnsServer2.Size = new System.Drawing.Size(138, 20);
            this.txtCustomDnsServer2.TabIndex = 4;
            // 
            // chkEnableDebugLogging
            // 
            this.chkEnableDebugLogging.AutoSize = true;
            this.chkEnableDebugLogging.Location = new System.Drawing.Point(12, 157);
            this.chkEnableDebugLogging.Name = "chkEnableDebugLogging";
            this.chkEnableDebugLogging.Size = new System.Drawing.Size(129, 17);
            this.chkEnableDebugLogging.TabIndex = 5;
            this.chkEnableDebugLogging.Text = "Enable debug logging";
            this.chkEnableDebugLogging.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Primary server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Secondary server:";
            // 
            // chkEnableThreading
            // 
            this.chkEnableThreading.AutoSize = true;
            this.chkEnableThreading.Location = new System.Drawing.Point(12, 59);
            this.chkEnableThreading.Name = "chkEnableThreading";
            this.chkEnableThreading.Size = new System.Drawing.Size(162, 17);
            this.chkEnableThreading.TabIndex = 19;
            this.chkEnableThreading.Text = "Enable multithreaded queries";
            this.chkEnableThreading.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "DNS query timeout (seconds):";
            // 
            // numDnsQueryTimeout
            // 
            this.numDnsQueryTimeout.Location = new System.Drawing.Point(166, 7);
            this.numDnsQueryTimeout.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numDnsQueryTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDnsQueryTimeout.Name = "numDnsQueryTimeout";
            this.numDnsQueryTimeout.Size = new System.Drawing.Size(39, 20);
            this.numDnsQueryTimeout.TabIndex = 21;
            this.numDnsQueryTimeout.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Number of retries if timed out:";
            // 
            // numDnsQueryRetries
            // 
            this.numDnsQueryRetries.Location = new System.Drawing.Point(166, 33);
            this.numDnsQueryRetries.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDnsQueryRetries.Name = "numDnsQueryRetries";
            this.numDnsQueryRetries.Size = new System.Drawing.Size(39, 20);
            this.numDnsQueryRetries.TabIndex = 23;
            this.numDnsQueryRetries.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 213);
            this.ControlBox = false;
            this.Controls.Add(this.numDnsQueryRetries);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numDnsQueryTimeout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkEnableThreading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkEnableDebugLogging);
            this.Controls.Add(this.txtCustomDnsServer2);
            this.Controls.Add(this.txtCustomDnsServer1);
            this.Controls.Add(this.btnCancelSettings);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.chkEnableCustomDnsServers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSettings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numDnsQueryTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDnsQueryRetries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnableCustomDnsServers;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnCancelSettings;
        private System.Windows.Forms.TextBox txtCustomDnsServer1;
        private System.Windows.Forms.TextBox txtCustomDnsServer2;
        private System.Windows.Forms.CheckBox chkEnableDebugLogging;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEnableThreading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDnsQueryTimeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numDnsQueryRetries;
    }
}