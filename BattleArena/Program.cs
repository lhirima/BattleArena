
using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static BattleArena.Warriors.Marksman;


namespace BattleArena
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var Mamamo = new Tank("Mamamo", 300, 15, 5);
            var Papamo = new Marksman("Papamo", 150, 32, 10);
            var Sino = new Fighter("Sino", 200, 20, 7);

            Mamamo.DisplayStatus();
            Papamo.DisplayStatus();
            Sino.DisplayStatus();

            while (Mamamo.IsAlive && Papamo.IsAlive)
            {
                Console.WriteLine("\n\n====================================");
                Mamamo.Attack(Papamo);
                Thread.Sleep(1000);
                Papamo.Attack(Mamamo);
                Thread.Sleep(1000);
                Console.WriteLine("------------------------------------");

            }

            Console.ReadKey();
        }
    }
}