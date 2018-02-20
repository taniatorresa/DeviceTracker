using System;
using System.Security.Principal;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DeviceTracker.Properties;

namespace DeviceTracker.NetworkAdapter
{
    public partial class FrmNetworkAdapter : Form
    {
        private List<NetworkAdapter> _allNetworkAdapters = new List<NetworkAdapter>();

        /// <summary>
        /// A ProgressInfo form
        /// </summary>
        private ProgressInfoForm _progressInfoForm = new ProgressInfoForm();

        /// <summary>
        /// The Current Operation Network Adapter
        /// </summary>
        private NetworkAdapter _currentNetworkAdapter = null;
        public FrmNetworkAdapter()
        {
            if (isAdministrator())
            {
                InitializeComponent();
                ShowAllNetworkAdapters();
                tsslbResult.Text = string.Format("{0}[{1}]",
                    Resources.StatusTextInitial,
                    _allNetworkAdapters.Count);
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
        private void ShowAllNetworkAdapters()
        {
            grpNetworkAdapters.Controls.Clear();

            _allNetworkAdapters = NetworkAdapter.GetAllNetworkAdapter();
            int i = 0;

            foreach (NetworkAdapter networkAdapter in _allNetworkAdapters)
            {
                i++;
                UCNetworkAdapter ucNetworkAdapter = new UCNetworkAdapter(
                    networkAdapter,
                    BtnEnableDisableNetworAdaptetClick,
                    new Point(10, 30 * i),
                    grpNetworkAdapters);
            }
        }
        private void ShowProgressInfo()
        {
            tsslbResult.Text = string.Empty;
            foreach (Control c in _progressInfoForm.Controls)
            {
                if (c is Label)
                {
                    c.Text = string.Format("{0}[{1}] ({2}) {3}",
                        Resources.StatusTextBegin,
                        _currentNetworkAdapter.DeviceId,
                        _currentNetworkAdapter.Name,
                        ((_currentNetworkAdapter.GetNetEnabled() != 1)
                        ? Resources.ProgressTextEnableEnd
                        : Resources.ProgressTextDisableEnd));
                }
            }

            _progressInfoForm.LocationX = Location.X
                + (Width - _progressInfoForm.Width) / 2;
            _progressInfoForm.LocationY = Location.Y
                + (Height - _progressInfoForm.Height) / 2;

            _progressInfoForm.ShowDialog();
        }
        public void BtnEnableDisableNetworAdaptetClick(object sender, EventArgs e)
        {
            Button btnEnableDisableNetworkAdapter = (Button)sender;

            // The result of enable or disable Network Adapter
            // result ={-1: Fail;0:Unknow;1:Success}
            int result = -1;
            int deviceId = ((int[])btnEnableDisableNetworkAdapter.Tag)[0];

            Thread showProgressInfoThreadProc =
                    new Thread(ShowProgressInfo);
            try
            {
                _currentNetworkAdapter = new NetworkAdapter(deviceId);

                // To avoid the condition of the network adapter netenable change caused 
                // by any other tool or operation (ex. Disconnected the Media) after you 
                // start the sample and before you click the enable\disable button.
                // In this case, the network adapter status shown in windows form is not
                // meet the real status.

                // If the network adapters' status is shown corrected,just to enable or 
                // disable it as usual.
                if (((int[])btnEnableDisableNetworkAdapter.Tag)[1]
                    == _currentNetworkAdapter.NetEnabled)
                {
                    // If Network Adapter NetConnectionStatus in ("Hardware not present",
                    // Hardware disabled","Hardware malfunction","Media disconnected"), 
                    // it will can not be enabled.
                    if (_currentNetworkAdapter.NetEnabled == -1
                        && (_currentNetworkAdapter.NetConnectionStatus >= 4
                            && _currentNetworkAdapter.NetConnectionStatus <= 7))
                    {
                        string error =
                            String.Format("{0}({1}) [{2}] {3} [{4}]",
                                          Resources.StatusTextBegin,
                                          _currentNetworkAdapter.DeviceId,
                                          Name,
                                          Resources.CanNotEnableMsg,
                                          NetworkAdapter.SaNetConnectionStatus
                                              [_currentNetworkAdapter
                                              .NetConnectionStatus]);

                        MessageBox.Show(error,
                                        Resources.OneCodeCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        showProgressInfoThreadProc.Start();

                        result = _currentNetworkAdapter.EnableOrDisableNetworkAdapter(
                            (_currentNetworkAdapter.NetEnabled == 1)
                            ? "Disable" : "Enable");

                        showProgressInfoThreadProc.Abort();
                    }
                }
                // If the network adapter status are not shown corrected, just to refresh
                // the form to show the correct network adapter status.
                else
                {
                    ShowAllNetworkAdapters();
                    result = 1;
                }
            }
            catch (NullReferenceException)
            {
                // If failed to construct _currentNetworkAdapter the result will be fail.
            }

            // If successfully enable or disable the Network Adapter
            if (result > 0)
            {
                ShowAllNetworkAdapters();
                tsslbResult.Text =
                    string.Format("{0}[{1}] ({2}) {3}",
                    Resources.StatusTextBegin,
                    _currentNetworkAdapter.DeviceId,
                    _currentNetworkAdapter.Name,
                    ((((int[])btnEnableDisableNetworkAdapter.Tag)[1] == 1)
                    ? Resources.StatusTextSuccessDisableEnd
                    : Resources.StatusTextSuccessEnableEnd));

                tsslbResult.ForeColor = Color.Green;
            }
            else
            {
                tsslbResult.Text =
                    string.Format("{0}[{1}] ({2}) {3}",
                    Resources.StatusTextBegin,
                    _currentNetworkAdapter.DeviceId,
                    _currentNetworkAdapter.Name,
                    ((((int[])btnEnableDisableNetworkAdapter.Tag)[1] == 1)
                    ? Resources.StatusTextFailDisableEnd
                    : Resources.StatusTextFailEnableEnd));

                tsslbResult.ForeColor = Color.Red;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
