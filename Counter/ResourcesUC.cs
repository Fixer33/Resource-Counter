using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public partial class ResourcesUC : UserControl
    {
        public ResourcesUC()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            base.Show();


        }

        private void ResourcesUC_Load(object sender, EventArgs e)
        {
            Location = new Point(0, 0);
            Hide();
        }
    }
}
