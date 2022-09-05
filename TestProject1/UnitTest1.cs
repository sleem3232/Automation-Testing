using NUnit.Framework;
using OpenQA.Selenium;

namespace TestProject1
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AreEqualTo15()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Assert.AreEqual("fizzbuzz", fizzBuzz.Fizz_Buzz(15));
        }
        [Test]
        public void AreEqualTo3()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Assert.AreEqual("fizz", fizzBuzz.Fizz_Buzz(3));
        }
        [Test]
        public void AreEqualTo5()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Assert.AreEqual("buzz", fizzBuzz.Fizz_Buzz(5));
        }
    }
}