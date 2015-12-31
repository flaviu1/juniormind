using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeptRent
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PenalityForMaximumTenDay()
        {
            Assert.AreEqual(104,CalculateDeptRent(100,2));
        }
        [TestMethod]
        public void PenalityForElevenToThirtyDay()
        {
            Assert.AreEqual(200, CalculateDeptRent(100, 20));
        }
        decimal rentDelay;
        decimal CalculateDeptRent(decimal price ,int day)
        {
            if ((day >= 1) || (day<= 10)) rentDelay = price + ((2 * price) / 100 * day);
            if ((day >= 11) || (day >= 30)) rentDelay = price + ((5 * price) / 100 * day);

            return rentDelay ;
           
        }

    }
}
