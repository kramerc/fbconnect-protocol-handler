using System.Collections;
using System.ComponentModel;
using System.Reflection;

namespace FBConnect_Protocol_Handler
{
    [RunInstaller(true)]
    public partial class AppInstaller : System.Configuration.Install.Installer
    {
        public AppInstaller()
        {
            InitializeComponent();
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

            string execFile = Assembly.GetExecutingAssembly().Location;
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\\Classes\\fbconnect\\shell\\open\\command");
            key.SetValue("", "\"" + execFile + "\" \"%1\"");
            key.Close();
        }
    }
}
