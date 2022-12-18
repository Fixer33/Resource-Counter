using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    internal class CraftingResource : CraftingComponent
    {
        private CraftingCost _cost;

        public CraftingResource(string name) : base(name)
        {
            _cost = new CraftingCost();
        }

        public override CraftingCost GetCraftingCost()
        {
            return _cost;
        }
    }
}
