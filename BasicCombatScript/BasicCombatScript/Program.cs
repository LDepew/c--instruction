using System;

namespace BasicCombatScript
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Combat");
            Console.WriteLine("Press any key to play.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Set your player HP.");
            int playerHP = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Set your player attack.");
            int playerAttack = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Set your enemy HP.");
            int baseEnemyHP = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Set you enemy attack.");
            int enemyAttack = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
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
