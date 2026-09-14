using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    internal class BB : Warrior, IHealCaster
    {
        public int HealingAmount { get; set; }
        public BB(string name, int health, int attackPower, int speed, TeamType teamType, int healingAmount)
            : base(name, health, attackPower, speed, WarriorType.Mage, teamType)
        {
            HealingAmount = healingAmount;
        }

       

        public override void Attack(Warrior target)
        {
            var damageInfo = new DamageInfo(AttackPower, "Heal", HasCriticalChance, this);
            TakeDamage(damageInfo);

            Console.WriteLine($"{Name} I'll heal u {target.Name}");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"{Name} ih  {target.Name}");
        }
        public void HealTeammates(int amount, List<Warrior> teammates)
        {
            foreach (var warrior in teammates)
            {
                if (warrior.IsAlive && warrior.TeamType == TeamType)
                {
                    Console.WriteLine($"{Name} heaaaaal {warrior.Name}");
                    warrior.ReceiveHealing(HealingAmount, this);
                }
                else
                    Console.WriteLine($"->{Name}: whut the{warrior.Name}" +
                        $"ghaaaaaad");
            }
        }
    }
}