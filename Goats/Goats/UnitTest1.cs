using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Goats
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(15, Calculatekg(1, 1, 15,1,1));
        }

        int Calculatekg(int day,int namber,int kg, int Qday,int Wnamber)
        {
            int ExactKg = (kg / day) / namber;
            int Amount = (ExactKg * Wnamber) * Qday;
            return Amount;
        }
    }   
}
