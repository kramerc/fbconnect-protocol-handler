using System;
using System.Web;
using System.Windows.Forms;

namespace FBConnect_Protocol_Handler
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                Uri uri = new Uri(args[1]);
                string fragment = uri.Fragment.Substring(1);
                
                txtAccessToken.Text = HttpUtility.ParseQueryString(fragment).Get("access_token");
            }
            else
            {
                MessageBox.Show("No URI was supplied", "FBConnect Protocol Handler");
                Application.Exit();
            }
        }
    }
}
