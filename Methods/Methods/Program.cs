using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi("Mike", 33);
            SayHi("John", 56);
            SayHi("Tom", 12);

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}
