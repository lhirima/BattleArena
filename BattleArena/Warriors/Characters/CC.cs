using BattleArena.Combat;
using System;
using BattleArena.Enums;
using System.Threading;


namespace BattleArena.Warriors.Characters
{

    public class CC : Warrior
    {
        public int WhirlDamage { get; private set; }
        public CC(int health, int attackPower, int whirlDamage, int speed, TeamType teamType)
            : base("CC ", health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            WhirlDamage = whirlDamage;
            attackPower += whirlDamage;
        }

        public CC(string name, int health, int attackPower, int speed, TeamType teamType)
            : base(name, health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            WhirlDamage = WhirlDamage;
        }

       

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Whirl", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"\t->{Name}: whiiiiii {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: yoohoo");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: ehhh {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t->* Damange Taken: {target}");
            Console.WriteLine($"\t->* Health Remaining: {target.Health}");

        }

    }
}