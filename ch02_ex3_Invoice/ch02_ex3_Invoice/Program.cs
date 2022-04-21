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

            while (runagain) {

            Console.Write("Enter subtotal: ");
                double subtotal = Convert.ToDouble(Console.ReadLine());

                double discountPercent;
                if (subtotal >= 200)
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

                String message = "Discount percent:  " + discountPercent + "\n"
                               + "Discount amount:   " + discountAmount + "\n"
                               + "Invoice total:     " + total + "\n";
                Console.WriteLine(message);

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
