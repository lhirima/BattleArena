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
            var mamamo = new Tank("mamamo", 300, 15, 5);
            var papamo = new Marksman("papamo", 150, 32, 10);
            var sino = new Fighter("sino", 200, 20, 7);

            mamamo.DisplayStatus();
            papamo.DisplayStatus();
            sino.DisplayStatus();

            while (mamamo.IsAlive && sino.IsAlive)
            {
                Console.WriteLine("\n\n====================================");
                mamamo.Attack(sino);
                Thread.Sleep(1000);
                sino.Attack(mamamo);
                Thread.Sleep(1000);
                Console.WriteLine("------------------------------------");

            }

            Console.ReadKey();
        }
    }
}