using System;

namespace GettersAndSetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "Dog");
            Movie shrek = new Movie("ShreK", "Adam Adamson", "PG");
            // G, PG, PG-13, R, NR
            shrek.Rating = "R";
            Console.WriteLine(shrek.Rating);
            Console.WriteLine(avengers.Rating);

            Console.ReadLine();
        }
    }
}
