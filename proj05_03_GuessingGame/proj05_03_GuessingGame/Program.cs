using System;

namespace proj05_03_GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guess the Number Game");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            Random random = new Random();
            bool runagain = true;

            while (runagain)
            {

                Console.WriteLine("I'm thinking of a number from 1 to 100.");
                int num = random.Next(1, 101);
                Console.WriteLine("Try to guess it.");
                Console.WriteLine();
                int guess = 0;

                int guessCount = 0;

                while (guess != num)
                {
                    Console.WriteLine("Enter number: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > num + 10)
                    {
                        Console.WriteLine("Way too high! Guess again.");
                    }
                    else if (guess > num)
                    {
                        Console.WriteLine("Too high! Guess again.");
                    }
                    else if (guess < num - 10)
                    {
                        Console.WriteLine("Way too low! Guess again.");
                    }
                    else if (guess < num)
                    {
                        Console.WriteLine("Too low! Guess again.");
                    }

                    guessCount++;
                }

                if (guessCount <= 3)
                {
                    Console.WriteLine("Great work! You are a mathematical wizarrd.");
                }
                else if (guessCount > 3 && guessCount <= 7)
                {
                    Console.WriteLine("Not too bad! You've got some potential.");
                }
                else if (guessCount > 7)
                {
                    Console.WriteLine("What took you so long? Maybe you should take some lessons.");
                }
                Console.WriteLine();

                Console.Write("Try again? (y/n): ");
                String loop = Console.ReadLine();

                    if (loop == "y")
                    {
                        runagain = true;
                    }
                    else if (loop == "n")
                    {
                        runagain = false;
                    }
            }

            Console.ReadLine();
        }
    }
}
