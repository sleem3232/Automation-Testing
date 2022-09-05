using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace Selenium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("autumation");
            driver.Close();
        }
       
    }
}
