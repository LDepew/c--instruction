using System;

namespace proj03_01_TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter");
            Console.WriteLine();

            bool runagain = true;

            while (runagain)
            {

                Console.WriteLine("Enter degrees in Fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());

                double celsius;
                celsius = (fahrenheit - 32) * 5 / 9;

                Console.WriteLine("Degrees in Celsius: " + (Math.Round(celsius, 2)));

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
