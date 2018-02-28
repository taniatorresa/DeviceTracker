using System;
using DeviceTracker.NetworkAdapter;
using DeviceTracker.Keyboard;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeviceTracker.Properties;
using System.Security.Principal;
namespace DeviceTracker
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
          
            
        }
        private bool isAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

  

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
           
            FrmNetworkAdapter frmNetworkAdapter = new FrmNetworkAdapter();
            frmNetworkAdapter.TopLevel = false;
            frmNetworkAdapter.Parent = Adaptador;
            frmNetworkAdapter.Show();
            frmNetworkAdapter.Dock = DockStyle.Fill;

            FrmKeyboard frmKeyboard = new FrmKeyboard();
            frmKeyboard.TopLevel = false;
            frmKeyboard.Parent = Teclados;
            frmKeyboard.Show();
            frmKeyboard.Dock = DockStyle.Fill;
        }

        private void Adaptador_Click(object sender, EventArgs e)
        {

        }
    }
}
