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
                Console.WriteLine(Name + " blocked the attack!");

                IsGuarding = false;
            }else
            {
                Health = Health - hit_value;

                Console.WriteLine(Name + " was hit for " + hit_value + " damage! You now have " + Health + " health remaning.\n");
                Thread.Sleep(1000);
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
            Console.WriteLine(Name + " has healed " + amount_to_heal + " health. You now have " + Health + " remaning.");
            Thread.Sleep(1000);
        }

        private void Die()
        {
            Console.WriteLine(Name + " has died!\n");

            IsDead = true;
        }
    }
    
}