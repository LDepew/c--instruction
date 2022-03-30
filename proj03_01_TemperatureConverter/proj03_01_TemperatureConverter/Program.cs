using System;

namespace proj03_01_TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter");
            Console.WriteLine();

            Console.WriteLine("Enter degrees in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius;
            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Degrees in Celsius: " + (Math.Round(celsius, 2)));

            Console.ReadLine();
        }
    }
}
