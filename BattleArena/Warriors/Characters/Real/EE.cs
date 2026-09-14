using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class EE : Warrior
    {
        public int Subo { get; private set; }
        public EE(int health, int attackPower, int Subo, int speed, TeamType teamType)
            : base("EE", health, attackPower, speed, WarriorType.Marksman, teamType)
        {
            this.Subo = Subo;
            attackPower += this.Subo;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "SwordSlash", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Ohhhh {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: oh?");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: HAHAHAHAHA {target.Name}");
        }
    }

}


