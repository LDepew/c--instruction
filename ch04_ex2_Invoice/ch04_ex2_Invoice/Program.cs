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
                Console.Write("Enter customer type (r/c/t): ");
                String customerType = Console.ReadLine();
                Console.Write("Enter subtotal: ");
                double subtotal = Convert.ToDouble(Console.ReadLine());

                double discountPercent = 0.0;
                /*switch (customerType)
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
                        else if (subtotal >= 250 && subtotal < 500)
                        {
                            discountPercent = .25;
                        } 
                        else if (subtotal > 500)
                        {
                            discountPercent = .3;
                        }
                        break;
                    case "c":
                    case "C":
                        discountPercent = .2;
                        break;
                    case "t":
                    case "T":
                        if (subtotal < 500)
                        {
                            discountPercent = .4;
                        }
                        else if (subtotal >= 500)
                        {
                            discountPercent = .5;
                        }
                        break;
                    default:
                        discountPercent = 0.0;
                        break;
                }*/
                if (customerType == "r" || customerType == "R"){

                    if (subtotal < 100)
                    {
                        discountPercent = 0.0;
                    }
                    else if (subtotal >= 100 && subtotal < 250)
                    {
                        discountPercent = .1;
                    }
                    else if (subtotal >= 250 && subtotal < 500)
                    {
                        discountPercent = .25;
                    }
                    else if (subtotal > 500)
                    {
                        discountPercent = .3;
                    }
                }
                else if (customerType == "c" || customerType == "C") {
                    discountPercent = .2;
                }
                else if (customerType == "t" || customerType == "T") {
                    if (subtotal < 500)
                    {
                        discountPercent = .4;
                    }
                    else if (subtotal >= 500)
                    {
                        discountPercent = .5;
                    }
                }
                else {
                    discountPercent = 0.0;
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
