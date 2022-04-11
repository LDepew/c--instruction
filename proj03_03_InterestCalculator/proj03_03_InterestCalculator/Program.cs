using System;

namespace proj03_03_InterestCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool runagain = true;

            while (runagain)
            {
                Console.WriteLine("Welcome to the Interest Calculator");

                Console.Write("Enter loan amount: ");
                decimal loanamt = Convert.ToDecimal(Console.ReadLine());
                string loanamount = String.Format("{0:C}", loanamt);

                Console.Write("Enter interest rate: ");
                decimal intrate = Convert.ToDecimal(Console.ReadLine());

                decimal interest = loanamt * intrate;
                string interestamt = String.Format("{0:C}", interest);

                Console.WriteLine("Loan amount: " + loanamount);

                Console.WriteLine("Interest rate: " + intrate.ToString("0.000") + "%");

                Console.WriteLine("Interest: " + interestamt);

                Console.Write("Continue (y/n): ");

                string loop = Console.ReadLine();

                if (loop == "y")
                {
                    runagain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    runagain = false;
                }

                Console.ReadLine();

            }
        }
    }
}
