using System;
using System.Drawing;
using System.Windows.Forms;
using DeviceTracker.Properties;
namespace DeviceTracker.Keyboard
{
    internal partial class UCKeyboard : UserControl
    {
        public UCKeyboard()
        {
            InitializeComponent();
        }
        public UCKeyboard(Keyboard keyboard,
               Point point,
               Control parent)
        {
            InitializeComponent();
            pctKeyboard.Image = Resources.keyboard;          
            lbName.Text = keyboard.Name;
            lbStatus.Text = keyboard.Status;

            Location = point;
            Parent = parent;
        }

        private void UCKeyboard_Load(object sender, EventArgs e)
        {

        }
    }

}
