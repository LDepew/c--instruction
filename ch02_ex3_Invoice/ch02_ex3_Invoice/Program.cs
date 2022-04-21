using System;

namespace ch02_ex3_Invoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Invoice Total Calculator");
            Console.WriteLine();

            bool runagain = true;

            double totalAmount = 0;
            double totalDiscount = 0;
            int numberInvoices = 0;

            while (runagain) {

            Console.Write("Enter subtotal: ");
                double subtotal = Convert.ToDouble(Console.ReadLine());

                double discountPercent;
                if (subtotal >= 500)
                {
                    discountPercent = .25;
                } else if (subtotal >= 200)
                {
                    discountPercent = .2;
                } else if (subtotal >= 100)
                {
                    discountPercent = .1;
                } else
                {
                    discountPercent = 0.0;
                }
                double discountAmount = subtotal * discountPercent;
                double total = subtotal - discountAmount;

                totalAmount = totalAmount + total;
                totalDiscount = totalDiscount + discountAmount;
                numberInvoices = numberInvoices + 1;

                String message = "Discount percent:  " + discountPercent + "\n"
                               + "Discount amount:   " + discountAmount + "\n"
                               + "Invoice total:     " + total + "\n";
                Console.WriteLine(message);

                Console.Write("Continue? (y/n): ");
                string loop = Console.ReadLine();

                if (loop == "y" || loop == "Y")
                {
                    runagain = true;
                }
                else if (loop == "n" || loop == "N")
                {
                    runagain = false;
                }
                else
                {
                    runagain = true;
                }

            }

            string message2 = "Number of invoices:  " + numberInvoices + "\n"
                            + "Average invoice:     " + totalAmount/ numberInvoices + "\n"
                            + "Average discount:    " + totalDiscount / numberInvoices + "\n";
            Console.WriteLine(message2);

            Console.ReadLine();
        }
    }
}
