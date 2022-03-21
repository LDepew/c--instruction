using System;

namespace BuildingAMadLibsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.WriteLine("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);

            Console.ReadLine();
        }
    }
}
