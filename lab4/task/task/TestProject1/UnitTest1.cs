using Microsoft.VisualStudio.TestTools.UnitTesting;
using task;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            InternetOperator operatorVelcom = InternetOperator.getInstance();
            operatorVelcom.setTariff(10, "velcom", 5);
            Assert.AreEqual(50, operatorVelcom.getTotalRevenue());
            operatorVelcom.setPrice(1000);
            Assert.AreEqual(5000, operatorVelcom.getTotalRevenue());
        }
    }
}
