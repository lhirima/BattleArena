using BattleArena.Combat;
using System;
using BattleArena.Enums;
using System.Threading;


namespace BattleArena.Warriors.Characters
{

    public class Alu : Warrior
    {
        public int WhirlDamage { get; private set; }
        public Alu(int health, int attackPower, int whirlDamage, int speed, TeamType teamType)
            : base("Alu", health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            WhirlDamage = whirlDamage;
            attackPower += whirlDamage;
        }

        public Alu(string name, int health, int attackPower, int speed, TeamType teamType)
            : base(name, health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            WhirlDamage = WhirlDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Whirl", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"\t->{Name}: yoohooo {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: ahh");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: dito ang tingin {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t->* Damange Taken: {target}");
            Console.WriteLine($"\t->* Health Remaining: {target.Health}");

        }

    }
}