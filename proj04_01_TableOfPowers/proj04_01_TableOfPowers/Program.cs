using System;

namespace proj04_01_TableOfPowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes Table");
            Console.WriteLine();

            bool runagain = true;

            while (runagain)
            {

                Console.WriteLine("Enter an integer: ");
                int number = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= number; i++)
                {
                    int squared = (i * i);

                    int cubed = ((i * i) * i);

                    Console.WriteLine("Number  Squared  Cubed");
                    Console.WriteLine("======  =======  =====");

                    Console.WriteLine(i + "      " + squared + "    " + cubed);

                }

                Console.WriteLine();
                Console.Write("Continue (y/n): ");
                string loop = Console.ReadLine();
                Console.WriteLine();

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
