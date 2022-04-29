using System;

namespace ch04_ex4_FutureValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Future Value Calculator\n");

            bool runagain = true;

            while (runagain)
            {

                Console.Write("Enter monthly investment: ");
                double monthlyInvestment = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter yearly interest rate: ");
                double interestRate = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number of years: ");
                int years = Convert.ToInt32(Console.ReadLine());

                double monthlyInterestRate = interestRate / 12 / 100;
                int months = years * 12;

                double futureValue = 0.0;
                for (int i = 1; i <= months; i++)
                {
                    futureValue = (futureValue + monthlyInvestment) *
                                  (1 + monthlyInterestRate);
                }

                Console.WriteLine("Future value: " + futureValue.ToString("C"));
                Console.WriteLine();

                Console.Write("Continue? (y/n): ");
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
