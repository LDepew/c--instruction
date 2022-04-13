using System;

namespace proj04_04_CommonDivisorCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greatest Common Divisior Finder");
            Console.WriteLine();

            bool runagain = true;

            while (runagain)
            {

                Console.Write("Enter first number: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int y = Convert.ToInt32(Console.ReadLine());

                int divisor = 0;
                while (x != 0)
                {
                    while (y >= x)
                    {
                        y = y - x;
                    }

                    divisor = x;
                    x = y;
                    y = divisor;
                }

                Console.WriteLine("Greatest Common Divisor: " + divisor);
                Console.WriteLine();

                Console.Write("Continue? (y/n): ");
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
