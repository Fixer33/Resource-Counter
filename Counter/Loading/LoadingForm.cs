using System;
using System.Threading;
using System.Windows.Forms;

namespace Counter.Loading
{
    public partial class LoadingForm : Form
    {
        private const int ANIMATION_DELAY = 10;
        private const double ANIMATION_STEP = 0.01;

        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Shown(object sender, EventArgs e)
        {
            while (this.Opacity < 1)
            {
                this.Opacity += ANIMATION_STEP;
                Thread.Sleep(ANIMATION_DELAY);
            }
            Thread.Sleep(1000);
            Close();
        }
    }
}
