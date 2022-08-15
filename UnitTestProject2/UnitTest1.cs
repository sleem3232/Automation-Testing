using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetTheSum_Number1_Number2()
        {
            GetTheSum sut = new GetTheSum
            {
                number1 = 30,
                number2 = 15

            };
            int sum = sut.GetTheSum();
            int expectedSum = 30;
            Assert.AreEqual(expectedSum, sum);
        }
    }
}
