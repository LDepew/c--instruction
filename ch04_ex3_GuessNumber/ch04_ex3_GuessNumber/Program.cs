using System;

namespace ch04_ex3_GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int LIMIT = 10;
            Random random = new Random();

            Console.WriteLine("Guess the number!");
            Console.WriteLine("I'm thinking of a number from 1 to " + LIMIT);
            Console.WriteLine();

            double d = random.Next(1, LIMIT);
            int number = (int)d;
            number++;

            int count = 0;
            int guess = 0;


            while (number != guess)
            {
                Console.Write("Your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < 1 || guess > LIMIT)
                {
                    Console.WriteLine("Invalid guess. Try again.");
                    continue;
                }

                else if (guess < number)
                {
                    Console.WriteLine("Too low.");
                } else if (guess > number)
                {
                    Console.WriteLine("Too high.");
                }
                count++;
            }

            Console.WriteLine("You guess it in " +
                              count + " tries.\n");

            Console.WriteLine("Bye!");
        }
    }
}
