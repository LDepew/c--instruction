using System;

namespace proj04_03_TipCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip Calculator");
            Console.WriteLine();

            Console.Write("Cost of meal: ");
            decimal cost = Convert.ToDecimal(Console.ReadLine());

            decimal tipfifteen = cost * 0.15m;

            decimal tiptwenty = cost * 0.20m;

            decimal tiptwentyfive = cost * 0.25m;

            Console.WriteLine("Tip amount 15%: " + tipfifteen);

            Console.WriteLine("Tip amount 20%: " + tiptwenty);

            Console.WriteLine("Tip amount 25%: " + tiptwentyfive);

            Console.ReadLine();
        }
    }
}
