using System;

namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //\n - new line break
            //\" - add " to middle of string

            string phrase = "Giraffe Academy";
            string phrase2 = "Giraffe Academy" + " is cool";

            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.Contains("Academy"));
            Console.WriteLine(phrase[2]);
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.IndexOf('f'));
            Console.WriteLine(phrase.Substring(8,3));

            Console.WriteLine(phrase2);

            Console.ReadLine();
        }
    }
}
