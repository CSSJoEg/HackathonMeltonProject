using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melton
{
    public abstract class ObtainableItem
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int MaximumStackableQuantity { get; set; }
        protected ObtainableItem()
        {
            MaximumStackableQuantity = 1;
        }
    }
}
