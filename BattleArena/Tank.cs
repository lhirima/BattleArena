using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public class Tank : Warrior
    {
        public int Shield;
        public Tank(string name, int health, int attackPower, int shield)
            : base(name, health, attackPower)
        {
            Shield = shield;
        }

        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower - Shield;
            TakeDamage(totalDamage);
            Console.WriteLine($"\t->{Name}: frozen {target.Name}!");
            Thread.Sleep(1000);
            Console.WriteLine($"\t->{target.Name}: ih ");
            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: ge! ");
            Thread.Sleep(1000);
            Console.WriteLine($"\t------- {target.Name} ------");
            Console.WriteLine($"\t    * DamageTaken: {totalDamage}");
            Console.WriteLine($"\t    * Health Remaining: {target.Health}");

        }

    }
}