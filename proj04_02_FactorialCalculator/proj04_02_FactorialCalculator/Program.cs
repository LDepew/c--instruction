using System;

namespace proj04_02_FactorialCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator");
            Console.WriteLine();

            bool runagain = true;

            while (runagain)
            {

                Console.Write("Enter an integer that's greater than 0 and less than 10: ");
                int input = Convert.ToInt32(Console.ReadLine());

                long fact = 1;

                for (int i = 1; i <= input; i++)
                {
                    fact = fact * i;
                }

                Console.WriteLine("The factorial of " + input + " is " + fact);

                Console.Write("Continue (y/n): ");
                string loop = Console.ReadLine();

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
