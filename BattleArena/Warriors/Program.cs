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
            // Ori-
            var AA = new AA(100, 30, 25, 10, TeamType.A);
            var BB = new BB(150, 20, 15, 10, TeamType.A);
            var CC = new CC(100, 10, 15, 30, TeamType.A);
            var DD = new DD(120, 15, 10, 20, TeamType.A);
            var EE = new EE(100, 20, 15, 10, TeamType.A);

            // ginal
            var Alu = new Alu(120, 15, 10, 30, TeamType.B);
            var Lance = new Lance(100, 20, 15, 10, TeamType.B);
            var Layla = new Layla(150, 10, 20, 15, TeamType.B);
            var Nani = new Nani(100, 15, 10, 20, TeamType.B);
            var Tig = new Tig(120, 10, 15, 30, TeamType.B);


            BattleArena.AddWarrior(AA);
            BattleArena.AddWarrior(BB);
            BattleArena.AddWarrior(CC);
            BattleArena.AddWarrior(DD);
            BattleArena.AddWarrior(EE);

            BattleArena.AddWarrior(Alu);
            BattleArena.AddWarrior(Lance);
            BattleArena.AddWarrior(Layla);
            BattleArena.AddWarrior(Nani);
            BattleArena.AddWarrior(Tig);


            BattleArena.StartBattle();
        }
    }
}