using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using task3;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(DayOfWeek.Thursday, DateService.GetDay("03.03.2022"));
            DateTime date = new DateTime(2022, 4, 3);
            Assert.AreEqual((DateTime.Now.Subtract(date)).Days, DateService.GetDaysSpan(2022, 4, 3));
        }
    }
}
