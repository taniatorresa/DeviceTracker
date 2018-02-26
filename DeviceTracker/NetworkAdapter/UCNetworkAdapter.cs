using System;
using System.Drawing;
using System.Windows.Forms;
using DeviceTracker.Properties;

namespace DeviceTracker.NetworkAdapter
{
    internal partial class UCNetworkAdapter : UserControl
    {
        public UCNetworkAdapter()
        {
            InitializeComponent();
        }
        public UCNetworkAdapter(NetworkAdapter networkAdapter,
            EventHandler eventHandler,
            EventHandler eventHandlerInfo,
            Point point,
            Control parent)
        {
            InitializeComponent();
            pctNetworkAdapter.Image = (networkAdapter.NetEnabled > 0)
                ? Resources.ImgEnabledNetworkAdapter
                : Resources.ImgDisabledNetworkAdapter;
            lbProductName.Text = networkAdapter.Name;
            lbConnectionStatus.Text =
                NetworkAdapter.SaNetConnectionStatus[networkAdapter.NetConnectionStatus];
            btnEnableDisable.Text = (networkAdapter.NetEnabled > 0)
                ? Resources.BtnText_Disable : Resources.BtnText_Enable;
            btnEnableDisable.Tag =
                new[] { networkAdapter.DeviceId, networkAdapter.NetEnabled };
            btnInfo.Tag =
            new[] { networkAdapter.DeviceId };
            btnInfo.Click += eventHandlerInfo;

            btnEnableDisable.Click += eventHandler;
            
            Location = point;
            Parent = parent;
        }

        private void UCNetworkAdapter_Load(object sender, EventArgs e)
        {

        }
    }
}
