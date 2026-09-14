using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    public static class BattleArena
    {
        static List<Warriors.Warrior> _warrior = new List<Warriors.Warrior>();


        public static void StartBattle()
        {
            DisplayWarriors();
        }
        public static void AddWarrior(Warriors.Warrior warrior)
        {
            _warrior.Add(warrior);
        }

        private static void DisplayWarriors()
        {
            var TeamA = _warrior.Where(w => w.Team == Enums.TeamType.A).ToList();
            var TeamB = _warrior.Where(w => w.Team == Enums.TeamType.B).ToList();

            Console.WriteLine("======= Team A =======");
            foreach (var warrior in TeamA)
                Console.WriteLine($"{warrior.Name}" +
                    $"\n Health: {warrior.Health}" +
                    $"\n Attack Power: {warrior.AttackPower}" +
                    $"\n Team: {warrior.Team}");

            Console.WriteLine("\n======= Team B =======");
            foreach (var warrior in TeamB)
                Console.WriteLine($"{warrior.Name}" +
                    $"\n Health: {warrior.Health}" +
                    $"\n Attack Power: {warrior.AttackPower}" +
                    $"\n Team: {warrior.Team}");
        }
    }
}