using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.warriors
{
    public class Warrior
    {
        public Warrior(string name, int health, int attackPower, string specialAttackName)
        {
            // Constructor implementation
        }

        // Other members of Warrior class
    }

    internal class Fighter : Warrior
    {
        public Fighter(string name, int health, int attackPower, string specialAttackName)
            : base(name, health, attackPower, specialAttackName)
        {

        }
    }
    internal class Marksman : Warrior
    {
        public Marksman(string name, int health, int attackPower, string specialAttackName)
            : base(name, health, attackPower, specialAttackName)
        {
        }
    }
}