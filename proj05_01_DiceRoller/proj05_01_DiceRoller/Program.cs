using System;

namespace proj05_01_DiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice Roller");
            Console.WriteLine();

            Console.WriteLine("Roll the dice? (y/n)");

            Random rand = new Random();

            int die1 = (rand.Next(1, 7));

            int die2 = (rand.Next(1, 7));

            int total = die1 + die2;

            Console.WriteLine("Die 1: " + die1);
            Console.WriteLine("Die 2: " + die2);
            Console.WriteLine("Total: " + total);

            Console.ReadLine();
        }
    }
}
