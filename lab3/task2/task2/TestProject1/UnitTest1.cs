using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2.Services;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("y = -2,758098062687748. ���������� ��������� �� 2� �����", FunctionCount.count(3, 4));
            Assert.AreEqual("y = -2,141592653589793. ���������� ��������� �� 1� �����", FunctionCount.count(-1, 2));
        }
    }
}
