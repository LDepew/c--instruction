using System;

namespace proj03_04_ChangeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Change Calculator");
            Console.WriteLine();

            bool runagain = true;

            while (runagain)
            {

                Console.Write("Enter number of cents (0-99): ");
                int cents = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                int quarters = cents / 25;
                Console.WriteLine("Quarters: " + quarters);

                int quartremain = cents % 25;

                int dimes = quartremain / 10;
                Console.WriteLine("Dimes: " + dimes);

                int dimesremain = quartremain % 10;

                int nickels = dimesremain / 5;
                Console.WriteLine("Nickels: " + nickels);

                int nickelsremain = dimesremain % 5;

                int pennies = nickelsremain / 1;
                Console.WriteLine("Pennies: " + pennies);

                Console.Write("Continue (y/n): ");
                string loop = Console.ReadLine();

                if (loop == "y")
                {
                    runagain = true;
                }
                else if (loop == "y") {
                    runagain = false;
                }
            }

            Console.ReadLine();
        }
    }
}
