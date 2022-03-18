using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

namespace DovizKuruOku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var driver = new ChromeDriver();

            while (true)
            {
                driver.Navigate().GoToUrl("https://bigpara.hurriyet.com.tr/doviz/dolar/");
                Thread.Sleep(5000);

                var kurElements = driver.FindElements(By.ClassName("kurBox"));
                var kurAlisElement = kurElements[1];
                var kurSatisElement = kurElements[2];
                //instrument - price - last

                var alisText = kurAlisElement.FindElements(By.TagName("span"))[1].Text;
                var satisText = kurSatisElement.FindElements(By.TagName("span"))[1].Text;
                Console.WriteLine($"Alis:{alisText}");
                Console.WriteLine($"Satis:{satisText}");
            }
        }
    }
}
