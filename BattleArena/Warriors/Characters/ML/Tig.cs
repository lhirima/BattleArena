using BattleArena.Combat;
using System;
using BattleArena.Enums;
using System.Threading;
using BattleArena.Abilities;

namespace BattleArena.Warriors.Characters
{
    public class Tig : Warrior, IDefender
    {
        public int Shield { get; set; }
        public Tig(int health, int attackPower, int shield, int speed, TeamType teamType)
            : base("Tig", health, attackPower, speed, WarriorType.Tank, teamType)
        {
            Shield = shield;
            attackPower += shield;
        }
        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Shield", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"\t->{Name}: Protect u {target.Name}!");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: ay");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{Name}: yessssss {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t->* Damange Taken: {target}");
            Console.WriteLine($"\t->* Health Remaining: {target.Health}");

        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Shield;

            var blockChance = _random.Next(0, 100);
            var isBlocked = blockChance < 50;
            _damageTaken = damage;

            if (isBlocked) Block();
            else
            {
                var newDmgInfo = new DamageInfo(newActualDamage, damage.AttackType, damage.IsCritical, damage.From);
                base.TakeDamage(newDmgInfo);
            }
        }

        public void Block()
        {
            var blockMessage = $"Blocked {_damageTaken.TotalAmountDamage} damage from {_damageTaken.From.Name}!";

        }
    }
}