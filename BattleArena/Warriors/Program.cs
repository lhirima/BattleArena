using BattleArena.Enums;
using BattleArena.Warriors.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var AA = new AA(100, 30, 10, 5, TeamType.A);
            var BB = new BB("BB", 200, 15, 20, TeamType.B, 8);
            var CC = new CC(150, 20, 15, 7, TeamType.A);

            AA.DisplayStatus();
            BB.DisplayStatus();
            CC.DisplayStatus();

            while (AA.IsAlive && BB.IsAlive)
            {
                Console.WriteLine("\n\n=================================================");
                AA.Attack(BB);
                BB.DisplayStatus();
                Console.WriteLine("-------------------------------------------------");
                Thread.Sleep(2000);
                BB.Attack(AA);
                AA .DisplayStatus();
                Thread.Sleep(2000);
            }

            Console.ReadKey();
        }
    }
}