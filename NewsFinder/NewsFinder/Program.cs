using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using static System.Net.WebRequestMethods;

namespace NewsFinder
{
    internal class Program
    {
        public IWebDriver driver;

        public void Setup()
        {
            driver = new ChromeDriver(".");
        }

        public void Main(string[] args)
        {
            Console.WriteLine("Youtube or Google: ");
            string selection = Console.ReadLine();

            if (selection == "Google" || selection == "google")
            {
                Console.WriteLine("Enter search terms: ");
                string query = Console.ReadLine();

                Console.WriteLine(query);

                string request = "https://www.google.com/search?q=" + query + "&sxsrf=ALiCzsaYhvj3AIkdOBeYwbV-p8H1ZYIYPA%3A1667163884606&source=hp&ei=7OZeY-iYIuas5NoPwt-LeA&iflsig=AJiK0e8AAAAAY170_HkY-d2394byCTrEswIk2hcwc37c&ved=0ahUKEwjovvy47Yj7AhVmFlkFHcLvAg8Q4dUDCAs&uact=5&oq=" + query + "&gs_lcp=Cgdnd3Mtd2l6EAMyBQgAEJECMgcIABCxAxBDMgcILhCxAxBDMgQIABBDMgoIABCxAxDJAxBDMgQILhBDMggIABCABBCxAzIECAAQQzILCC4QgAQQsQMQgwEyBAgAEEM6BAgjECc6BQguEIAEOgUIABCABDoICC4QsQMQgwE6EQguEIAEELEDEIMBEMcBENEDOg4ILhCABBCxAxCDARDUAjoQCC4QsQMQgwEQxwEQ0QMQQzoGCAAQChBDOgcIABDJAxBDUABY1wRg2wVoAHAAeACAAWOIAaMEkgEBNpgBAKABAQ&sclient=gws-wiz";
                ProcessStartInfo ps = new ProcessStartInfo
                {
                    FileName = request,
                    UseShellExecute = true
                };
                Process.Start(ps);

                driver.Navigate().GoToUrl(request);

                //accept privacy
                driver.FindElement(By.XPath("//div[text()='I agree']")).Click();

                //type something and press Enter
                driver.FindElement(By.Name("q")).SendKeys("Retrieve Index" + Keys.Enter);

                //get all a elements 
                var a_webElements = driver.FindElements(By.XPath("//div[@class='g']/div/div/a"));


                //print the index for all
                for (int i = 0; i < a_webElements.Count; i++)
                {
                    Console.WriteLine($"The index is {i} for the url {a_webElements[i].GetAttribute("href")}");
                }

                WebClient webClient = new WebClient();
                webClient.Proxy = new WebProxy("http://www.google.com");
                string str = webClient.DownloadString("http://www.google.com/search?q=" + query);
                using (StreamWriter writetext = new StreamWriter("write.txt"))
                {
                    writetext.WriteLine(str);
                }
                //Console.WriteLine(str);
            }
            else if (selection == "Youtube" || selection == "youtube")
            {
                Console.WriteLine("Enter search terms: ");
                string query = Console.ReadLine();

                string request = "https://www.youtube.com/results?search_query=" + query;
                ProcessStartInfo ps = new ProcessStartInfo
                {
                    FileName = request,
                    UseShellExecute = true
                };
                Process.Start(ps);
            }
        }
    }
}
