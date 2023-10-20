using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melton
{
    public class Reviver : ObtainableItem
    {
        public Reviver()
        {
            MaximumStackableQuantity = 10;
        }
    }
    public class LegendarySword : ObtainableItem { }
    public class LegendaryBow : ObtainableItem { }
    public class LegendaryStaff : ObtainableItem { }
    public class LegendaryArmor : ObtainableItem { }
    public class LegendaryAmulet : ObtainableItem { }
}
