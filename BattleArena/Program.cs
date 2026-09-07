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
            Warrior Mamamo = new Warrior();
            Mamamo.Name = "Mamamo";
            Mamamo.Health = 300;
            Mamamo.AttackPower = 50;

            Warrior Papamo = new Warrior();
            Papamo.Name = "Papamo";
            Papamo.Health = 200;
            Papamo.AttackPower = 40;

            Warrior Sino = new Warrior();
            Sino.Name = "Sino";
            Sino.Health = 150;
            Sino.AttackPower = 30;


            Console.WriteLine($"{Mamamo.Name} has " +
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