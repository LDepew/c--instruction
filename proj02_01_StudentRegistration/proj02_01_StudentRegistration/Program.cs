using System;

namespace proj02_01_StudentRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form");
            Console.WriteLine();

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter birth year: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Welcome " + firstName + " " + lastName);
            Console.WriteLine("Your registration is complete");
            Console.WriteLine("Your temporary password is: " + firstName + "*" + birthYear);

            Console.ReadLine();
        }
    }
}
