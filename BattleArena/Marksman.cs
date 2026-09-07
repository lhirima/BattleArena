using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public class Marksman : Warrior
    {
        public int ArrowDamage;
        public Marksman(string name, int health, int attackPower, int arrowDamage)
            : base(name, health, attackPower)
        {
        }

        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower + ArrowDamage;
            TakeDamage(totalDamage);
            Console.WriteLine($"\t->{Name}: fire arrow {target.Name}!");
            Thread.Sleep(1000);
            Console.WriteLine($"\t->{target.Name}: oh! ");
            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: weh ");
            Thread.Sleep(1000);
            Console.WriteLine($"\t------- {target.Name} ------");
            Console.WriteLine($"\t    * DamageTaken: {totalDamage}");
            Console.WriteLine($"\t    * Health Remaining: {target.Health}");
        }
    }
}