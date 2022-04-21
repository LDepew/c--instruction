using System;

namespace ch03_ex1_MPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Miles Per Gallon calculator");
            Console.WriteLine();

            bool runagain = true;

            while (runagain)
            {

                Console.Write("Enter miles driven: ");
                double miles = Convert.ToDouble(Console.ReadLine());
                

                Console.Write("Enter gallons of gas used: ");
                double gallons = Convert.ToDouble(Console.ReadLine());

                double mpg = miles / gallons;
                Console.WriteLine("Miles per gallon is " + mpg.ToString("#.##") + ".");
                Console.WriteLine();

                Console.Write("Calculate another MPG? (y/n): ");
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
