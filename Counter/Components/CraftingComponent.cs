using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    internal abstract class CraftingComponent
    {
        public string Name { get; protected set; }

        public CraftingComponent(string name)
        {
            Name = name;
        }

        public CraftingComponent(CraftingComponentSerializable data)
        {
            this.Name = data.Name;
        }

        public abstract CraftingCost GetCraftingCost();
        public virtual CraftingComponentSerializable GetSerializable()
        {
            CraftingComponentSerializable data = new CraftingComponentSerializable(CraftingComponentSerializable.Type.Resource, Name);
            if (this is CraftingRecipe)
            {
                data.CType = CraftingComponentSerializable.Type.Recipe;
            }
            return data;
        }

        public static CraftingComponent CreateFromSerializedData(CraftingComponentSerializable data)
        {
            if (data.CType == CraftingComponentSerializable.Type.Resource)
            {
                return new CraftingResource(data.Name);
            }

            return new CraftingRecipe(data.Name);
        }
    }

    [Serializable]
    public struct CraftingComponentSerializable
    {
        public Type CType;
        public string Name;
        public KeyValuePair<string, int>[] Components;

        public CraftingComponentSerializable(Type type, string name, KeyValuePair<string, int>[] components = null)
        {
            CType = type;
            Name = name;
            if (components != null)
                Components = components;
            else
                Components = new KeyValuePair<string, int>[0];
        }

        [Serializable]
        public enum Type
        {
            Resource,
            Recipe
        }
    }
}
