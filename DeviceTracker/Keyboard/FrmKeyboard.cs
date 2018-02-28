using System;
using System.Security.Principal;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Management;
using System.Threading;
using DeviceTracker.WMI;
using System.Windows.Forms;
using DeviceTracker.Properties;
namespace DeviceTracker.Keyboard
{
    public partial class FrmKeyboard : Form
    {
        
        private List<Keyboard> _allKeyboards = new List<Keyboard>();


        private ProgressInfoForm _progressInfoForm = new ProgressInfoForm();
        public FrmKeyboard()
        {
            if (isAdministrator())
            {
                InitializeComponent();
                ShowAllKeyboards();
             //   tsslbResult.Text = string.Format("{0}[{1}]",
                    //Resources.StatusTextInitial,
                    //_allKeyboards.Count);
            }
            else
            {
                MessageBox.Show(Resources.MsgElevatedRequire,
                    Resources.OneCodeCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Environment.Exit(1);
            }
        }
        private bool isAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void ShowAllKeyboards()
        {
           // grpNetworkAdapters.Controls.Clear();

            _allKeyboards = Keyboard.GetAllKeyboards();
            int i = 0;

            foreach (Keyboard keyboard in _allKeyboards)
            {
                i++;
                UCKeyboard ucKeyboard = new UCKeyboard(
                    keyboard,   
                    new Point(10, 30 * i),
                    grpKeyboard);
            }
        }
    }
}
