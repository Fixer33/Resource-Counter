using System;
using System.Drawing;
using System.Windows.Forms;

namespace Counter
{
    public partial class ProfilesUC : UserControl
    {
        public ProfilesUC()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            base.Show();

            PopulateList();
        }

        private void PopulateList()
        {
            listBox1.Items.Clear();
            var profiles = ProfileManager.Profiles.ToArray();
            var selected = ProfileManager.SelectedProfile;
            for (int i = 0; i < profiles.Length; i++)
            {
                listBox1.Items.Add(profiles[i]);

                if (selected != null && selected.Name == profiles[i].Name)
                    SelectProfile(selected);
            }
        }

        private void SelectProfile(Profile profile)
        {
            listBox1.SelectedItem = profile;
            FillProfileInfo(profile);
        }

        private void FillProfileInfo(Profile profile)
        {
            ProfileNameTextBox.Text = profile.Name;
        }

        private void ProfilesUC_Load(object sender, EventArgs e)
        {
            Location = new Point(0, 0);
            Hide();
        }

        private void AddNewProfileBut_Click(object sender, EventArgs e)
        {
            if (ProfileManager.CreateProfile())
            {
                PopulateList();
            }
        }

        private void LoadProfileBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProfileManager.SelectProfile(listBox1.SelectedItem.ToString());
            FillProfileInfo(ProfileManager.SelectedProfile);
        }

        private void SaveProfileInfoBut_Click(object sender, EventArgs e)
        {
            if (ProfileNameTextBox.Text == "")
            {
                MessageBox.Show(MBEmptyNameText.Text);
                return;
            }

            ProfileManager.ModifySelectedProfile(ProfileNameTextBox.Text);
            PopulateList();
        }
    }
}
