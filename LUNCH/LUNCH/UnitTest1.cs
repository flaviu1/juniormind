using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LUNCH
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(12, CalculateCMMMC(4, 6));
        }
        int CalculateCMMMC(int fourDay, int sixDay )
        {
            int product = fourDay * sixDay;
            while (fourDay != sixDay)
            {
                if (fourDay > sixDay)
                    fourDay = fourDay - sixDay;
                else
                    sixDay = sixDay - fourDay;
            }
            return product = product / fourDay;
        }
    }
}
