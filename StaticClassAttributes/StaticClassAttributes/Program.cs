using System;

namespace StaticClassAttributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zepplin", 150);

            Console.WriteLine(kashmir.getSongCount());
            Console.WriteLine(kashmir.title);

            Console.ReadLine();
        }
    }
}
