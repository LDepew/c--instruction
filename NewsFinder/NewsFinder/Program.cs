using System;
using System.Diagnostics;

namespace NewsFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter search terms: ");
            String query = Console.ReadLine();

            Console.WriteLine(query);

            string request = "https://www.google.com/search?q=" + query + "&sxsrf=ALiCzsaYhvj3AIkdOBeYwbV-p8H1ZYIYPA%3A1667163884606&source=hp&ei=7OZeY-iYIuas5NoPwt-LeA&iflsig=AJiK0e8AAAAAY170_HkY-d2394byCTrEswIk2hcwc37c&ved=0ahUKEwjovvy47Yj7AhVmFlkFHcLvAg8Q4dUDCAs&uact=5&oq=" + query + "&gs_lcp=Cgdnd3Mtd2l6EAMyBQgAEJECMgcIABCxAxBDMgcILhCxAxBDMgQIABBDMgoIABCxAxDJAxBDMgQILhBDMggIABCABBCxAzIECAAQQzILCC4QgAQQsQMQgwEyBAgAEEM6BAgjECc6BQguEIAEOgUIABCABDoICC4QsQMQgwE6EQguEIAEELEDEIMBEMcBENEDOg4ILhCABBCxAxCDARDUAjoQCC4QsQMQgwEQxwEQ0QMQQzoGCAAQChBDOgcIABDJAxBDUABY1wRg2wVoAHAAeACAAWOIAaMEkgEBNpgBAKABAQ&sclient=gws-wiz";
            ProcessStartInfo ps = new ProcessStartInfo
            {
                FileName = request,
                UseShellExecute = true
            };
            Process.Start(ps);
        }
    }
}
