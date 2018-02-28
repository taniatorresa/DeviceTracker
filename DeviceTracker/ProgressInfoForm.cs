using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceTracker
{
    public partial class ProgressInfoForm : Form
    {
        public ProgressInfoForm()
        {
            InitializeComponent();
        }
        public int LocationX
        {
            get;
            set;
        }

  
        public int LocationY
        {
            get;
            set;
        }

        private void ProgressInfoForm_Load(object sender, EventArgs e)
        {
            Location = new Point(LocationX, LocationY);
        }
    }
}
