using System;

namespace ch04_ex2_Invoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runagain = true;

            while (runagain)
            {
                Console.Write("Enter customer type (r/c): ");
                String customerType = Console.ReadLine();
                Console.Write("Enter subtotal: ");
                double subtotal = Convert.ToDouble(Console.ReadLine());

                double discountPercent = 0.0;
                switch (customerType)
                {
                    case "r":
                    case "R":
                        if (subtotal < 100)
                        {
                            discountPercent = 0.0;
                        }
                        else if (subtotal >= 100 && subtotal < 250)
                        {
                            discountPercent = .1;
                        }
                        else if (subtotal >= 250)
                        {
                            discountPercent = .2;
                        }
                        break;
                    case "c":
                    case "C":
                        if (subtotal < 250)
                        {
                            discountPercent = .2;
                        }
                        else if (subtotal >= 250)
                        {
                            discountPercent = .3;
                        }
                        break;
                    default:
                        discountPercent = .1;
                        break;
                }

                double discountAmount = subtotal * discountPercent;
                discountAmount = Math.Ceiling(discountAmount * 100) / 100;

                double total = subtotal - discountAmount;

                Console.WriteLine(
                    "Discount percent: " + (discountPercent.ToString("P")) + "\n"
                  + "Discount amount:  " + (discountAmount.ToString("C")) + "\n"
                  + "Total:            " + (total.ToString("C")) + "\n"
                    );

                Console.Write("Continue? (y/n): ");
                String loop = Console.ReadLine();

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
