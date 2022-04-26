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
            Console.Write(Name);
            Console.Write(" was hit for ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(hit_value);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" damage! You now have "); 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Health); 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" health remaning.\n");  
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