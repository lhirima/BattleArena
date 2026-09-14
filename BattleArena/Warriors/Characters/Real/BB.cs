using BattleArena.Combat;
using System;
using System.Threading;
using BattleArena.Enums;

namespace BattleArena.Warriors.Characters
{
    public class BB : Warrior
    {
        public int CritMultiplier { get; private set; }

        public BB(int health, int attackPower, int critMultiplier, int speed, TeamType teamType)
            : base("BB", health, attackPower, speed, WarriorType.Assasin, teamType)
        {
            CritMultiplier = critMultiplier;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Stab", HasCriticalChance, this);

            Console.WriteLine($"->{Name}: Strike {target.Name}...");
            Thread.Sleep(1000);

            if (dmginfo.IsCritical)
                Console.WriteLine($"-> Critical! Damage x{CritMultiplier}");

            TakeDamage(dmginfo);

            
        }
    }
}