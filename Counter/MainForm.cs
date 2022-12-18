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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Hide();
            new Loading.LoadingForm().ShowDialog();
            Show();
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HideAllUserContols()
        {
            optionsUC1.Hide();
            profilesUC1.Hide();
            recipesUC1.Hide();
            resourcesUC1.Hide();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            HideAllUserContols();
            optionsUC1.Show();
        }

        private void ProfilesSelector_Click(object sender, EventArgs e)
        {
            HideAllUserContols();
            profilesUC1.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProfileManager.SaveProfiles();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProfileManager.LoadProfiles();
        }

        private void Craftables_Click(object sender, EventArgs e)
        {
            HideAllUserContols();
            recipesUC1.Show();
        }

        private void Resources_Click(object sender, EventArgs e)
        {
            HideAllUserContols();
            resourcesUC1.Show();
        }
    }
}
