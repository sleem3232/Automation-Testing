using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemo
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
          
        }

        [Test]
        public void Test1()
        {
            //open browser
            IWebDriver webDriver = new ChromeDriver(@"C:\Users\PC\Downloads\New folder");
            //nav
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");

            //identify login
            IWebElement uselogin = webDriver.FindElement(By.LinkText("Login"));
            uselogin.Click();
            //username
            var txtUsername=webDriver.FindElement(By.Name("UserName"));
            Assert.That(txtUsername.Displayed,Is.True);
            txtUsername.SendKeys("salims");
            webDriver.FindElement(By.Name("Password")).SendKeys("Salim!!!1");
            webDriver.FindElement(By.XPath("//input[@value='Log in']")).Submit();
          

            /* var txtpassword = webDriver.FindElement(By.Name("Password"));
             Assert.That(txtpassword.Displayed,Is.True);
             txtpassword.SendKeys("Salim!!!1");
             IWebElement uselogin2 = webDriver.FindElement(By.XPath("//input[@value='Log in'"));

             uselogin2.Click()*/
            ;

        }
    }
}