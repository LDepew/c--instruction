using System;

namespace TurnBasedCombatGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHP = 40;
            int enemyHP = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;

            Random random = new Random();

            while (playerHP > 0 && enemyHP > 0)
            {
                Console.WriteLine(" -- Player turn -- ");
                Console.WriteLine("Player Hp - " + playerHP + ". Enemy Hp - " + enemyHP);
                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

                string Choice = Console.ReadLine();

                if (Choice == "a")
                {
                    enemyHP -= playerAttack;
                    Console.WriteLine("Player attack enemy and deals " + playerAttack + " damage!");
                }
                else
                {
                    playerHP += healAmount;
                    Console.WriteLine("Player restores " + healAmount + " health points!");
                }

                if (enemyHP > 0)
                {
                    Console.WriteLine(" -- Enemy turn -- ");
                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        playerHP -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage!");
                    }
                    else
                    {
                        enemyHP += healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " health points!");
                    }
                }
            }

            if (playerHP > 0)
            {
                Console.WriteLine("Congratulations, you have won!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.ReadKey();

        }
    }
}
