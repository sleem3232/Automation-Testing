using CalcNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc2Numbers.Test
{
    [TestClass]
    public class SumOFnum
    {
        [TestMethod]
        public void CheckTheSum()
        {
            GetTheSum getTheSum = new GetTheSum
            {
                number1 = 15,
                number2 = 15
            };
            var actual = getTheSum.sum();
            Assert.AreEqual(30, actual);

        }
    }
}
