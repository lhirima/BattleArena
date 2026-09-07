using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Warrior Mamamo = new Warrior("Mamamo", 300, 50);
            Warrior Papamo = new Warrior("Papamo", 10, 1);
            Warrior Sino = new Warrior("Sino", 100, 20);

            Console.WriteLine($"{Mamamo .Name} has " +
                $"{Mamamo.Health} health and {Mamamo.AttackPower} attack power.");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine($"{Papamo.Name} has " +
                $"{Papamo.Health} health and {Papamo.AttackPower} attack power.");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine($"{Sino.Name} has " +
                $"{Sino.Health} health and {Sino.AttackPower} attack power.");
            Console.WriteLine("----------------------------------------------");

            Console.ReadLine();
        }

    }
}