using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(42, Digits.swapDigits(24));
            Assert.AreEqual(242, Digits.swapDigits(242));
            Assert.AreEqual(536, Digits.swapDigits(536));
            Assert.AreEqual(78, Digits.swapDigits(87));
        }
    }
}
