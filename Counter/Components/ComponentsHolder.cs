using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    internal static class ComponentsHolder
    {
        private static Dictionary<string, CraftingComponent> _components = new Dictionary<string, CraftingComponent>();

        public static void InitializeComponents()
        {
            _components.Clear();

            var profile = ProfileManager.SelectedProfile;
            if (profile == null)
                return;

            foreach (var item in profile.CraftingComponents)
            {
                var comp = CraftingComponent.CreateFromSerializedData(item.Value);
                _components.Add(comp.Name, comp);
            }
        }

        #region Creating
        public static bool CreateNewRecipe(string name)
        {
            if (_components.ContainsKey(name) || ProfileManager.SelectedProfile == null)
                return false;

            var newRec = new CraftingRecipe(name);
            CreateNewComponent(newRec);

            return true;
        }

        public static bool CreateNewResource(string name)
        {
            if (_components.ContainsKey(name) || ProfileManager.SelectedProfile == null)
                return false;

            var newRec = new CraftingResource(name);
            CreateNewComponent(newRec);

            return true;
        }

        private static void CreateNewComponent(CraftingComponent component)
        {
            _components.Add(component.Name, component);
            ProfileManager.SelectedProfile.AddNewComponent(component.GetSerializable());
        } 
        #endregion

        public static CraftingComponent GetComponent(string name)
        {
            return _components[name];
        }

        public static string[] GetComponentNames(bool includeRecipes, bool includeResources)
        {
            List<string> result = new List<string>();
            foreach (var item in _components.Values)
            {
                if ((includeRecipes && item is CraftingRecipe) || (includeResources && item is CraftingResource))
                    result.Add(item.Name);
            }
            return result.ToArray();
        }
    }
}
