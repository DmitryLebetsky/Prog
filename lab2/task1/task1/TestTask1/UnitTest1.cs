using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;

namespace TestTask1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, Program.check(3, 3, 3));
            Assert.AreEqual(false, Program.check(2, 5, 6));
        }
    }
}
