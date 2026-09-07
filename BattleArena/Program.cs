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
            int round = 1;
            Warrior Mamamo = new Warrior("Mamamo", 300, 15, "Dinilaan");
            Warrior Papamo = new Warrior("Papamo", 150, 32, "Sinubo");
            Warrior Sino = new Warrior("Sino", 200, 20, "Pinwetan");

            Mamamo.DisplayStatus();
            Papamo.DisplayStatus();
            Sino.DisplayStatus();

            while (Mamamo.IsAlive && Papamo.IsAlive)
            {
                Console.WriteLine($"---------------- Round {round}  ----------------");
                Papamo.Attack(Mamamo);
                Mamamo.Attack(Papamo);
                Console.WriteLine("------------------------------------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}