using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melton
{
    public interface IMeleeCreature
    {
        float DodgeValue { get; set; }
    }
    public interface IHealingCreature
    {
        int HealingValue { get; set; }
        void DoHeal(MeltonCreature creature);
    }
    public interface IManaCreature
    {
        int Mana { get; set; }
    }
    public interface IRangedCreature
    {
        float AttackSpeed { get; set; }
    }
}
