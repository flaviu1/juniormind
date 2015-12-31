using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeptRent
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PenalityForTenDay()
        {
            Assert.AreEqual(104,CalculateDeptRent(100,2));
        }

        decimal CalculateDeptRent(decimal price ,int day)
        {
            decimal priceForMaximumTenAay;
            priceForMaximumTenAay = price + ((2 * price) / 100 * day);
            return priceForMaximumTenAay;
           
        }

    }
}
