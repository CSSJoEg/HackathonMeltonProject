using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melton
{
    public abstract class MeltonCreature : CharacterInfo
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public int Attack { get; set; }
        public int Range { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public void DoAttack(MeltonCreature creature)
        {
            creature.Health -= this.Attack;
        }
    }
}
