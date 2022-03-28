using System;

namespace GettersAndSetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("ShreK", "Adam Adamson", "PG");
            // G, PG, PG-13, R, NR

            Console.WriteLine(avengers.rating);

            Console.ReadLine();
        }
    }
}
