using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace ClandestineDevelopment.Tools.BatchDnsLookup
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            Assembly a = Assembly.GetExecutingAssembly();
            lblProductVersion.Text = String.Format("{0} v{1}", a.GetName().Name, a.GetName().Version.ToString());

            object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            lblCopyright.Text = ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
        }

        private void linkJHSoftware_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.simpledns.com");
        }

        private void linkClandestine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://clandestine.dk");
        }
    }
}
