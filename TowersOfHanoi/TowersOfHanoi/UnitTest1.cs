using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TowersOfHanoi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForFourDisc()
        {
            Assert.AreEqual(15, ChangeDiscWithMethodTowersHanoi(4));
            Assert.AreEqual(1023, ChangeDiscWithMethodTowersHanoi(10));
        }
        int ChangeDiscWithMethodTowersHanoi(int number)
        {
            if (number == 1) return 1;
            return (2 * ChangeDiscWithMethodTowersHanoi(number - 1)) + 1;
        }
    }
}
