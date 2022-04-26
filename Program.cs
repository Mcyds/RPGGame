using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Storing username
            Console.WriteLine("---------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter your name: ");
            Console.ForegroundColor = ConsoleColor.White;

            //Create the player character 
            Player player = new Player()
            {
                Name = Console.ReadLine()
            };

            Console.WriteLine("---------------------------------------------------------");

            Thread.Sleep(1000);

            Console.WriteLine($"Welcome {player.Name}!\n");

            //Enemy1 condition

            Random random = new Random();

            Enemy firstEnemy = new Enemy("Giant Crab");

            GameLoop(firstEnemy, random, player, 10, 15);

            if (!player.IsDead)
            {
                Boss boss = new Boss();

                GameLoop(boss, random, player, 50, 50);

                if (!player.IsDead)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("     ▒▒          ░░░░          ░░");
                    Console.WriteLine("     ▒▒░░      ░░░░░░░░      ░░░░");
                    Console.WriteLine("     ▓▓▒▒░░  ░░░░░░░░░░░░  ░░░░▒▒");
                    Console.WriteLine("     ██▓▓▒▒░░░░░░▓▓▓▓░░░░░░░░▓▓▓▓");
                    Console.WriteLine("     ██▓▓▒▒░░░░▓▓▓▓▓▓▓▓░░░░░░▓▓▓▓");
                    Console.WriteLine("     ▓▓▒▒▒▒▒▒░░▓▓▓▓▓▓▓▓░░░░░░░░▒▒");
                    Console.WriteLine("     ▒▒▒▒▒▒▒▒▒▒░░▓▓▓▓░░░░░░░░░░░░");
                    Console.WriteLine("       ▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░  \n");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("You have defeated the enemies! Continue your journey.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    GameOver();
                }

            }
            else
            {
                GameOver();
            }
        }

        private static void GameOver()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\n     ███████████████████████████");
            Console.WriteLine("     ███████▀▀▀░░░░░░░▀▀▀███████");
            Console.WriteLine("     ████▀░░░░░░░░░░░░░░░░░▀████");
            Console.WriteLine("     ███│░░░░░░░░░░░░░░░░░░░│███");
            Console.WriteLine("     ██▌│░░░░░░░░░░░░░░░░░░░│▐██");
            Console.WriteLine("     ██░└┐░░░░░░░░░░░░░░░░░┌┘░██");
            Console.WriteLine("     ██░░└┐░░░░░░░░░░░░░░░┌┘░░██");
            Console.WriteLine("     ██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██");
            Console.WriteLine("     ██▌░│██████▌░░░▐██████│░▐██");
            Console.WriteLine("     ███░│▐███▀▀░░▄░░▀▀███▌│░███");
            Console.WriteLine("     ██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██");
            Console.WriteLine("     ██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██");
            Console.WriteLine("     ████▄─┘██▌░░░░░░░▐██└─▄████");
            Console.WriteLine("     █████░░▐█─┬┬┬┬┬┬┬─█▌░░█████");
            Console.WriteLine("     ████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████");
            Console.WriteLine("     █████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████");
            Console.WriteLine("     ███████▄░░░░░░░░░░░▄███████");
            Console.WriteLine("     ██████████▄▄▄▄▄▄▄██████████");
            Console.WriteLine("     ███████████████████████████\n");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("GAME OVER!!!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--ATACAN BILGEN--");
        }

        private static void GameLoop(Enemy enemy, Random random, Player player, int max_attack_power, int max_player_attack)
        {
            //Player chooses action
            Thread.Sleep(2000);
            Console.WriteLine($"{player.Name} you have encountered a {enemy.Name}!\n");
            Console.WriteLine("                   ▓▓▓▓▓▓▓▓▓▓▓▓                    ");
            Console.WriteLine("       ▓▓▓▓      ▓▓▓▓▓▓▓▓  ▓▓▓▓▓▓                  ");
            Console.WriteLine("       ▓▓      ▓▓▓▓    ▓▓██    ██                  ");
            Console.WriteLine("       ▓▓▓▓    ▓▓▓▓    ████              ▓▓▓▓      ");
            Console.WriteLine("         ▓▓    ▓▓▓▓                        ▓▓▓▓    ");
            Console.WriteLine("         ▓▓▓▓  ▓▓████        ▓▓        ▓▓    ██    ");
            Console.WriteLine("           ▓▓▓▓  ██▓▓▓▓▓▓▓▓▓▓          ▓▓▓▓▓▓██    ");
            Console.WriteLine("     ▓▓      ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  ▓▓    ▓▓▓▓██    ");
            Console.WriteLine("     ▓▓▓▓▓▓    ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓        ▓▓██    ");
            Console.WriteLine("       ▓▓▓▓████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      ▓▓██    ");
            Console.WriteLine("               ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓    ████  ▓▓");
            Console.WriteLine("         ▓▓██████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████    ██");
            Console.WriteLine("       ▓▓▓▓      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████    ████");
            Console.WriteLine("       ▓▓  ▓▓▓▓██████▓▓▓▓▓▓▓▓▓▓████████  ▓▓▓▓▓▓██  ");
            Console.WriteLine("         ▓▓▓▓        ████▓▓▓▓██████████▓▓          ");
            Console.WriteLine("         ▓▓▓▓            ▓▓████████    ▓▓▓▓    ██  ");
            Console.WriteLine("           ▓▓▓▓              ▓▓  ▓▓▓▓    ▓▓▓▓▓▓██  ");
            Console.WriteLine("                             ▓▓    ▓▓▓▓            ");
            Console.WriteLine("                           ████      ██            ");
            Console.WriteLine("                       ▓▓████      ████            ");
            Thread.Sleep(1000);

            //While the first enemy and the player is not dead, repeat the action
            while (!enemy.IsDead && !player.IsDead)
            {

                Thread.Sleep(1000);
                Console.WriteLine("\nWhat would you like to do?\n");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n1. Single Attack\n2. Three Strike Attack\n3. Defend\n4. Heal\n");
                Console.ForegroundColor = ConsoleColor.White;

                string playerAction = Console.ReadLine();
                //Check for type of action
                if (playerAction == "1")
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"\nYou chose to attack the {enemy.Name} once!\n");

                    enemy.GetsHit(random.Next(1, max_player_attack));

                }
                else if (playerAction == "2")
                {
                    Console.WriteLine($"\nYou chose to attack {enemy.Name} thrice!\n");

                    for (int i = 0; i < 3; i++)
                    {

                        enemy.GetsHit(random.Next(1, max_player_attack));

                        if (enemy.IsDead)
                        {
                            break;
                        }
                    }

                }
                else if (playerAction == "3")
                {
                    Console.WriteLine("\nYou chose to defend!\n");
                    Thread.Sleep(1000);

                    player.IsGuarding = true;

                }
                else if (playerAction == "4")
                {
                    Console.WriteLine("\nYou chose to heal!\n");

                    player.Heal(random.Next(1, 30));
                }
                else
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("\nYou chose something else!\n");
                }

                if (!enemy.IsDead)
                {
                    player.GetsHit(random.Next(1, max_attack_power));
                }

            }
        }
    }
}