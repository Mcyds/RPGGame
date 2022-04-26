using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Enemy
    {   
        public int Health { get; set; }
        public String Name { get; set; }
        public bool IsDead { get; set; }

        public Enemy(string name)
        {
            Health = 100;

            Name = name;
        }

        public void GetsHit(int hit_value)
        {
            Health = Health - hit_value;
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Name + " was hit for " + hit_value + " damage! He now has " + Health + " health remaning.\n");
            Console.ForegroundColor = ConsoleColor.White;
            if (Health <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Name + " has died!\n");
            Console.ForegroundColor = ConsoleColor.White;
            IsDead = true;
        }
    }
    
}