using System;

namespace proj03_02_TravelTimeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator");
            Console.WriteLine();

            Console.Write("Enter miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter miles per hour: ");
            double mph = Convert.ToDouble(Console.ReadLine());

            double hours = miles / mph;

            double minutes = miles % mph;

            Console.WriteLine("Estimated travel time");
            Console.WriteLine("---------------------");
            Console.WriteLine("Hours: " + (Math.Round(hours, 0)));
            Console.WriteLine("Minutes: " + minutes);

            Console.ReadLine();
        }
    }
}
