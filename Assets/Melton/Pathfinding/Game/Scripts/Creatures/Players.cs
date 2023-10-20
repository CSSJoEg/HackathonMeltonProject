using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melton
{
    public class Warrior : MeltonCreature, IMeleeCreature
    {
        public float DodgeValue { get; set; }
        public void Charge(MeltonCreature creature)
        {
            creature.Health -= this.Attack;
            creature.Health -= this.Attack;
        }
    }
    public class Hunter : MeltonCreature, IRangedCreature
    {
        public int Energy { get; set; }
        public float AttackSpeed { get; set; }
        public void RapidArrow(MeltonCreature creature)
        {
            creature.Health -= this.Attack;
        }
    }
    public class Mage : MeltonCreature, IManaCreature, IRangedCreature
    {
        public int Mana { get; set; }
        public float AttackSpeed { get; set; }
        public void CastFireball(MeltonCreature creature)
        {
            creature.Health -= this.Attack + 20;
        }
    }
    public class Shaman : MeltonCreature, IHealingCreature, IManaCreature, IRangedCreature
    {
        public float AttackSpeed { get; set; }
        public int HealingValue { get; set; }
        public int Mana { get; set; }
        public void DoHeal(MeltonCreature creature)
        {
            creature.Health += this.HealingValue;
            this.Mana = this.Mana - 10;
        }
    }
}
