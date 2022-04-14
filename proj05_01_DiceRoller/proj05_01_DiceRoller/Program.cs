using System;

namespace proj05_01_DiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice Roller");
            Console.WriteLine();

            bool runagain = true;

        
            Console.Write("Roll the dice? (y/n)");
            string roll = Console.ReadLine();

            if (roll == "y")
            {

                while (runagain)
                {
                    Random rand = new Random();

                    int die1 = (rand.Next(1, 7));

                    int die2 = (rand.Next(1, 7));

                    int total = die1 + die2;

                    Console.WriteLine("Die 1: " + die1);
                    Console.WriteLine("Die 2: " + die2);
                    Console.WriteLine("Total: " + total);

                    if (die1 == 1 && die2 == 1)
                    {
                        Console.WriteLine("Snake eyes!");
                    }
                    else if (die1 == 6 && die2 == 6)
                    {
                        Console.WriteLine("Box cars!");
                    }

                    Console.WriteLine();
                    Console.Write("Roll again? (y/n)");
                    string loop = Console.ReadLine();

                    if (loop == "y")
                    {
                        runagain = true;
                    }
                    else if (loop == "n")
                    {
                        runagain = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Selection");
                    }
                }
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
            
            Console.ReadLine();
        }
    }
}
