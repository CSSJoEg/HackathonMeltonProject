using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melton
{
    public class Boss : MeltonCreature
    {
        public float AttackSpeed { get; set; }
        public int AOE { get; set; }
        public double Rage { get; set; }
        public void DoSpecialAttack(MeltonCreature creature)
        {
            creature.Health -= this.AOE;
            creature.Health -= this.AOE;
        }
    }
}
