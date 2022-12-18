using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    internal struct CraftingCost
    {
        public bool CanBeCalculated
        { 
            get
            {
                for (int i = 0; i < _components.Count; i++)
                {
                    if (_components[i] is CraftingRecipe)
                        return true;
                }
                return false;
            } 
        }

        private List<CraftingComponent> _components;
    }
}
