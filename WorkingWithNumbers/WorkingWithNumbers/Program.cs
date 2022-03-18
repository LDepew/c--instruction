using System;

namespace WorkingWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 6;

            num++;

            Console.WriteLine(-5.783);
            Console.WriteLine(5 + 8);
            Console.WriteLine(5 - 8);
            Console.WriteLine(5 * 8);
            Console.WriteLine(5 / 8);
            Console.WriteLine(5 % 2);
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine((4 + 2) * 3);
            Console.WriteLine(5.0 + 8.1);
            Console.WriteLine(5 + 8.1);
            Console.WriteLine(5 / 2);
            Console.WriteLine(5 / 2.0);
            Console.WriteLine(num);


            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.3));


            Console.ReadLine();
        }
    }
}
