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
            Console.WriteLine();

            decimal tipfifteen = cost * 0.15m;
            string tipfifteenamt = string.Format("{0:C}", tipfifteen);
            decimal totalcostfifteen = cost + tipfifteen;
            string totalcostfifteenamt = string.Format("{0:C}", totalcostfifteen);

            decimal tiptwenty = cost * 0.20m;
            string tiptwentyamt = string.Format("{0:C}", tiptwenty);
            decimal totalcosttwenty = cost + tiptwenty;
            string totalcosttwentyamt = string.Format("{0:C}", totalcosttwenty);

            decimal tiptwentyfive = cost * 0.25m;
            string tiptwentyfiveamt = string.Format("{0:C}", tiptwentyfive);
            decimal totalcosttwentyfive = cost + tiptwentyfive;
            string totalcosttwentyfiveamt = string.Format("{0:C}", totalcosttwentyfive);

            Console.WriteLine("15%");
            Console.WriteLine("Tip amount 15%: " + tipfifteenamt);
            Console.WriteLine("Total amount: " + totalcostfifteenamt);
            Console.WriteLine();

            Console.WriteLine("20%");
            Console.WriteLine("Tip amount 20%: " + tiptwentyamt);
            Console.WriteLine("Total amount: " + totalcosttwentyamt);
            Console.WriteLine();

            Console.WriteLine("25%");
            Console.WriteLine("Tip amount 25%: " + tiptwentyfiveamt);
            Console.WriteLine("Total amount: " + totalcosttwentyfiveamt);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
