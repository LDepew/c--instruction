using System;

namespace proj02_02_GradeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter");
            Console.WriteLine();

                Console.Write("Enter numerical grade: ");
                int numGrade;
                numGrade = Convert.ToInt32(Console.ReadLine());

                string letterGrade = null;

                if (numGrade >= 88 && numGrade <= 100)
                {
                    letterGrade = "A";
                }
                else if (numGrade >= 80 && numGrade <= 88)
                {
                    letterGrade = "B";
                }
                else if (numGrade >= 67 && numGrade <= 79)
                {
                    letterGrade = "C";
                }
                else if (numGrade >= 60 && numGrade <= 66)
                {
                    letterGrade = "D";
                }
                else if (numGrade < 60)
                {
                    letterGrade = "F";
                }

                Console.WriteLine("Letter Grade: " + letterGrade);
                Console.WriteLine();
            

            Console.ReadLine();
        }
        

    }
}
