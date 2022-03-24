using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2;

namespace TestTask2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Точка внутри", Program.check(1.4, 0.5));
            Assert.AreEqual("Точка снаружи", Program.check(5.2, 6.7));
            Assert.AreEqual("Точка на границе", Program.check(2.4, 0));
        }
    }
}
