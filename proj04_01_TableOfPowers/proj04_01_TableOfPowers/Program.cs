using System;

namespace proj04_01_TableOfPowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes Table");
            Console.WriteLine();

            Console.WriteLine("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int squared = (number * number);

            int cubed = ((number * number) * number);

            Console.WriteLine("Number  Squared  Cubed");
            Console.WriteLine("======  =======  =====");

            Console.WriteLine(number + "      " + squared + "    " + cubed);

            Console.ReadLine();
        }
    }
}
