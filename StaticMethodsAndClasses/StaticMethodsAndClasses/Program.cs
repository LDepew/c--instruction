using System;

namespace StaticMethodsAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(144));

            UsefulTools.sayHi("Lance");

            Console.ReadLine();
        }
    }
}
