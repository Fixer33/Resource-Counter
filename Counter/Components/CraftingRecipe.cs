using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    internal class CraftingRecipe : CraftingComponent
    {
        private List<CraftingComponent> _components;
        private CraftingCost? _lastCost;

        public CraftingRecipe(string name) : base(name)
        {
            
        }

        public override CraftingCost GetCraftingCost()
        {
            if (_lastCost != null)
                return (CraftingCost)_lastCost;

            throw new Exception();
        }
    }
}
