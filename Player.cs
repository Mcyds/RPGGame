using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        public int Health { get; set; }

        public string Name { get; set; }

        public bool IsDead { get; set; }

        public bool IsGuarding { get; set; }

        public Player()
        {
            Health = 100;

        }

        public void GetsHit(int hit_value)
        {
            if (IsGuarding)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Name + " blocked the attack!");
                Console.ForegroundColor = ConsoleColor.White;
                IsGuarding = false;
            }
            else
            {
                Health = Health - hit_value;
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(Name);
                Console.Write(" was hit for ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(hit_value);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" damage! You now have "); 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(Health); 
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" health remaning.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (Health <= 0)
            {
                Die();
            }
        }

        public void Heal(int amount_to_heal)
        {
            Health = Health + amount_to_heal;

            if (Health > 100)
            {
                Health = 100;
            }
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(Name);
            Console.Write(" has healed ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(amount_to_heal);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" health. You now have ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Health);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" remaning.");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
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