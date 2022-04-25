using System;

namespace ch03_ex2_TestScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter test scores that range from 0 to 100.");
            Console.WriteLine("To end the program, enter 999");
            Console.WriteLine();

            int scoreTotal = 0;
            int scoreCount = 0;
            int testScore = 0;

            int minScore = 0;
            int interumScore = 0;
            int maxScore = 0;

            while (testScore != 999)
            {
                Console.Write("Enter score: ");
                testScore = Convert.ToInt32(Console.ReadLine());

                if (testScore <= 100)
                {
                    scoreCount++;
                    scoreTotal += testScore;
                }
                else if (testScore != 999)
                {
                    Console.WriteLine("Invalid entry, not counted");
                }
                
            }

            double averageScore = (double)scoreTotal / scoreCount;
            string message = "\n"
                    + "Score count:   " + scoreCount + "\n"
                    + "Score total:   " + scoreTotal + "\n"
                    + "Average score: " + averageScore + "\n"
                    + "Minimum score: " + minScore + "\n"
                    + "Maximum score: " + maxScore + "\n";
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
