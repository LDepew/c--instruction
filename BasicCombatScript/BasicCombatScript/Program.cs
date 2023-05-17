using System;

namespace BasicCombatScript
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            Console.WriteLine("Simple Combat");
            Console.WriteLine("Press any key to play.");
            Console.ReadKey();
            Console.Clear();

            int playerHP = rnd.Next(1, 200);
            Console.WriteLine("player HP: " + playerHP);
            //playerHP = Convert.ToInt32(Console.ReadLine());

            int playerAttack = rnd.Next(1, 30);
            Console.WriteLine("player attack: " + playerAttack);
            //int playerAttack = Convert.ToInt32(Console.ReadLine());

            int baseEnemyHP = rnd.Next(1, 200);
            Console.WriteLine("enemy HP: " + baseEnemyHP);
            //baseEnemyHP = Convert.ToInt32(Console.ReadLine());

            int enemyAttack = rnd.Next(1, 30);
            Console.WriteLine("enemy attack: " + enemyAttack);
            //int enemyAttack = Convert.ToInt32(Console.ReadLine());

            //Console.Clear();
            while (playerHP > 0)
            {

                int enemyHP = baseEnemyHP;

                while (enemyHP > 0)
                {
                    Console.WriteLine("Press any key to hit the enemy.");
                    Console.ReadKey();

                    enemyHP -= playerAttack;

                    if (enemyHP > 0)
                    {
                        Console.WriteLine("The enemy hit you!");

                        playerHP -= enemyAttack;
                    }

                    Console.Clear();

                    Console.WriteLine("Player HP: " + playerHP);
                    Console.WriteLine("Enemy HP: " + enemyHP);
                }

                Console.WriteLine("The enemy has been defeated.");
                Console.WriteLine("Press any key to fight again.");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("You were defeated.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
