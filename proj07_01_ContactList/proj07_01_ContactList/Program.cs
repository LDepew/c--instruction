using System;

namespace proj07_01_ContactList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Contact List application");
            Console.WriteLine();

            bool runagain = true;

            while (runagain)
            {


                Console.WriteLine("Enter first name: ");
                string firstName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter last name: ");
                string lastName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter email: ");
                string email = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter phone: ");
                string phone = Convert.ToString(Console.ReadLine());

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("---- Current Contact ----------------------");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Name:          " + firstName + " " + lastName);
                Console.WriteLine("Email Address: " + email);
                Console.WriteLine("Phone Number:  " + phone);
                Console.WriteLine("-------------------------------------------");

                Console.WriteLine();
                Console.WriteLine("Continue (y/n): ");
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
