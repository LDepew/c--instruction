using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            

            Book book2 = new Book("Lord of the Rings", "Tolkien", 700);

            Book book3 = new Book();

            book2.title = "The Hobbit";

            Console.WriteLine(book2.title);

            Console.ReadLine();
        }
    }
}
