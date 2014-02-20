namespace ClandestineDevelopment.Tools.BatchDnsLookup
{
    partial class frmAbout
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
            this.lblProductVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.linkJHSoftware = new System.Windows.Forms.LinkLabel();
            this.linkClandestine = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblProductVersion
            // 
            this.lblProductVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductVersion.Location = new System.Drawing.Point(12, 9);
            this.lblProductVersion.Name = "lblProductVersion";
            this.lblProductVersion.Size = new System.Drawing.Size(342, 25);
            this.lblProductVersion.TabIndex = 1;
            this.lblProductVersion.Text = "Product and version";
            this.lblProductVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Location = new System.Drawing.Point(12, 22);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(342, 30);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "Copyright statement";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkJHSoftware
            // 
            this.linkJHSoftware.LinkArea = new System.Windows.Forms.LinkArea(66, 24);
            this.linkJHSoftware.Location = new System.Drawing.Point(11, 52);
            this.linkJHSoftware.Name = "linkJHSoftware";
            this.linkJHSoftware.Size = new System.Drawing.Size(345, 30);
            this.linkJHSoftware.TabIndex = 4;
            this.linkJHSoftware.TabStop = true;
            this.linkJHSoftware.Text = "Batch DNS Lookup is built using JH Software\'s DNS Client Library. http://www.simp" +
    "ledns.com";
            this.linkJHSoftware.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkJHSoftware.UseCompatibleTextRendering = true;
            this.linkJHSoftware.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkJHSoftware_LinkClicked);
            // 
            // linkClandestine
            // 
            this.linkClandestine.LinkArea = new System.Windows.Forms.LinkArea(37, 14);
            this.linkClandestine.Location = new System.Drawing.Point(12, 98);
            this.linkClandestine.Name = "linkClandestine";
            this.linkClandestine.Size = new System.Drawing.Size(342, 19);
            this.linkClandestine.TabIndex = 5;
            this.linkClandestine.TabStop = true;
            this.linkClandestine.Text = "For updates and other software visit clandestine.dk";
            this.linkClandestine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkClandestine.UseCompatibleTextRendering = true;
            this.linkClandestine.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClandestine_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 128);
            this.Controls.Add(this.linkClandestine);
            this.Controls.Add(this.linkJHSoftware);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblProductVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProductVersion;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.LinkLabel linkJHSoftware;
        private System.Windows.Forms.LinkLabel linkClandestine;
    }
}