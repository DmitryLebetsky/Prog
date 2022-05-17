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
            Provider provider = new Provider();

            Tariff velcomTariff = new Tariff("velcom", 100);
            Customer customerDmitry = new Customer("Дмитрий", 20);
            Customer customerAlex = new Customer("Александр", 10);
            velcomTariff.registerCustomer(customerDmitry);
            velcomTariff.registerCustomer(customerAlex);
            provider.addTariff(velcomTariff);

            Tariff MTSTariff = new Tariff("MTS", 20);
            Customer customerMasha = new Customer("Маша", 30);
            Customer customerDasha = new Customer("Даша", 15);
            MTSTariff.registerCustomer(customerMasha);
            MTSTariff.registerCustomer(customerDasha);
            provider.addTariff(MTSTariff);
            Assert.AreEqual(3900, provider.getTotalConsumedTrafficPrice());
            Assert.AreEqual("Маша", provider.getRichestCustomer());
        }
    }
}
