using System;
using System.Web;
using System.Windows.Forms;

namespace FBConnect_Protocol_Handler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                Uri uri = new Uri(args[1]);
                string fragment = uri.Fragment.Substring(1);
                
                accessTokenTextBox.Text = HttpUtility.ParseQueryString(fragment).Get("access_token");
            }
            else
            {
                MessageBox.Show("No URI was supplied", "FBConnect Protocol Handler");
                Application.Exit();
            }
        }
    }
}
