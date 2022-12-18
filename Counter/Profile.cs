using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Counter
{
    public class Profile
    {
        public string Name { get; private set; }
        internal Dictionary<string, CraftingComponentSerializable> CraftingComponents { get; private set; } = new Dictionary<string, CraftingComponentSerializable>();

        private Status _status;

        private Profile(string name)
        {
            Name = name;
        }

        private Profile(ProfileSerializable data)
        {
            Name = data.Name;
        }

        private void OnModify()
        {
            if (_status != Status.Created)
                _status = Status.Modified;
        }

        #region Basic actions
        public void Save()
        {
            if (_status == Status.Unmodified)
                return;

            string path = Path.Combine("Profiles", Name);
            using (var fs = File.Create(path))
            {
                var serializer = new XmlSerializer(typeof(ProfileSerializable));
                ProfileSerializable profile = GetSerializableObject();
                serializer.Serialize(fs, profile);
                fs.Close();
            }
        }

        public void Delete()
        {
            string path = Path.Combine("Profiles", Name);
            File.Delete(path);
        }

        public void Modify(string newName)
        {
            if (newName != null)
            {
                Name = newName;
            }

            OnModify();
        }
        #endregion

        #region Components actions

        public void AddNewComponent(CraftingComponentSerializable data)
        {
            CraftingComponents.Add(data.Name, data);
            OnModify();
        }

        public void DeleteComponent(string name)
        {
            CraftingComponents.Remove(name);
            OnModify();
        }

        public void UpdateComponent(CraftingComponentSerializable data)
        {
            CraftingComponents[data.Name] = data;
            OnModify();
        }
        #endregion

        #region Serialization
        private ProfileSerializable GetSerializableObject()
        {
            return new ProfileSerializable()
            {
                Name = Name,
                Components = CraftingComponents.Select(item => item.Value).ToList()
            };
        }

        public static Profile Create(string name)
        {
            string path = Path.Combine("Profiles", name);
            if (File.Exists(path))
                File.Delete(path);

            return new Profile(name)
            {
                _status = Status.Created
            };
        }

        public static Profile LoadFromFile(string path)
        {
            using (var fs = File.OpenRead(path))
            {
                var deserializer = new XmlSerializer(typeof(ProfileSerializable));
                var result = (ProfileSerializable)deserializer.Deserialize(fs);
                fs.Close();
                return new Profile(result);
            }
        }  
        #endregion

        public override string ToString()
        {
            return Name;
        }

        [Serializable]
        public struct ProfileSerializable
        {
            public string Name;
            public List<CraftingComponentSerializable> Components;
        }

        private enum Status
        {
            Unmodified = 0,
            Created = 1,
            Modified = 2
        }
    }
}
