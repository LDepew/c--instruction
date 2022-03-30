using System;

namespace proj02_03_RectangleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            Console.WriteLine();

            Console.WriteLine("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = width * length;
            Console.WriteLine("Area: " + area);

            double perimeter = (2 * width) + (2 * length);
            Console.WriteLine("Perimeter : " + perimeter);

            Console.ReadLine();
        }
    }
}
