using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public abstract class Warrior
    {
        private bool _IsAlive;
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }

        public bool IsAlive
        {
            get
            {
                _IsAlive = Health > 0;
                return _IsAlive;
            }
            private set { _IsAlive = value; }
        }

        public Warrior(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        protected virtual void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }



        public virtual void DisplayStatus()
        {
            Console.WriteLine($"\t---{Name}---");
            Console.WriteLine($"\t[+] Health: {Health}");
            Console.WriteLine($"\t[+] AttackPower: {AttackPower}");
        }


        public abstract void Attack(Warrior target);
    }
}