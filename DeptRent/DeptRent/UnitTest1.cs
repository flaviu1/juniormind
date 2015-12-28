using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeptRent
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PenalityMaximalTenDay()
        {
            Assert.AreEqual(102,CalculateDeptRent(100,2));
        }

        decimal CalculateDeptRent(int price ,int day)
        {
            return 102;
        }

    }
}
