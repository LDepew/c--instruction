using System;

namespace proj05_02_DataValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            Console.WriteLine();

            bool runagain = true;

            while (runagain)
            {

                Console.Write("Enter length: ");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter width: ");
                double width = Convert.ToDouble(Console.ReadLine());

                double area = width * length;
                double perimeter = (2 * width) + (2 * length);

                Console.WriteLine("Area: " + Math.Round(area, 2));
                Console.WriteLine("Perimeter: " + Math.Round(perimeter, 2));

                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
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
