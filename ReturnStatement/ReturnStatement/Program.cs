using System;

namespace ReturnStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);

            Console.WriteLine(cube(5));

            Console.ReadLine();   
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
