using BattleArena.Combat;
using System;
using BattleArena.Enums;
using System.Threading;


namespace BattleArena.Warriors.Characters
{

    public class AA : Warrior
    {
        public int PunchDamage { get; private set; }
        public AA(int health, int attackPower, int punchDamage, int speed, TeamType teamType)
            : base("AA", health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            PunchDamage = punchDamage;
            attackPower += punchDamage;
        }

        public AA(string name, int health, int attackPower, int speed, TeamType teamType)
            : base(name, health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            PunchDamage = PunchDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Punch", HasCriticalChance, this);
            // Apply damage to the target (not to self)
            TakeDamage(dmginfo);

            Console.WriteLine($"\t->{Name}: Take a hit from {target.Name}!");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: yeouch!");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{Name}: Argh! {target.Name}!");

        }

    }
}