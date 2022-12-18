using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    internal static class ProfileManager
    {
        public static Profile SelectedProfile
        {
            get
            {
                if (_selectedId < 0)
                    return null;

                return Profiles[_selectedId];
            }
        }
        public static List<Profile> Profiles { get; private set; } = new List<Profile>();

        private static int _selectedId = -1;

        public static bool CreateProfile()
        {
            if (Profiles.Where(item => item.Name == "").Any())
                return false;

            Profiles.Add(Profile.Create(""));
            SelectProfile("");
            return true;
        }

        public static void DeleteSelectedProfile()
        {
            var profile = ProfileManager.SelectedProfile;
            if (profile == null)
                return;

            Profiles.Remove(profile);
            _selectedId = -1;
            profile.Delete();
        }

        public static void ModifySelectedProfile(string newName)
        {
            if (Profiles.Where(item => item.Name == newName).Any())
            {
                MessageBox.Show("Name exists");
                return;
            }

            var profile = ProfileManager.SelectedProfile;
            if (profile == null)
                return;

            profile.Modify(newName);
            Profiles[_selectedId] = profile;
        }

        public static void SelectProfile(string name)
        {
            _selectedId = Profiles.Where(item => item.Name == name).Select(i => Profiles.IndexOf(i)).First();
        }

        public static void LoadProfiles()
        {
            if (Directory.Exists("Profiles") == false)
                return;

            var files = Directory.GetFiles("Profiles");
            for (int i = 0; i < files.Length; i++)
            {
                var profile = Profile.LoadFromFile(files[i]);
                Profiles.Add(profile);
            }
        }

        public static void SaveProfiles()
        {
            if (Directory.Exists("Profiles") == false)
                Directory.CreateDirectory("Profiles");

            foreach (var item in Profiles)
            {
                item.Save();
            }
        }
    }
}
