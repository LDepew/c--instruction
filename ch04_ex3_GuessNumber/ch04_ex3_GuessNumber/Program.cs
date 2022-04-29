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

            int count = 1;

            while (true)
            {
                Console.Write("Your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess < 1 || guess > LIMIT)
                {
                    Console.WriteLine("Invalid guess. Try again.");
                    continue;
                }

                if (guess < number)
                {
                    Console.WriteLine("Too low.");
                } else if (guess > number)
                {
                    Console.WriteLine("Too high.");
                } else
                {
                    Console.WriteLine("You guessed it in " +
                                      count + " tries.\n");
                    break;
                }
                count++;
            }

            Console.WriteLine("Bye!");
        }
    }
}
