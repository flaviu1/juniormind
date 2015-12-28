using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMelone
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ForKilogramsEven()
        {
            Assert.AreEqual("yes", CalculateMeloneForFriends(20));
        }
        [TestMethod]
        public void ForOdd()
        {
            Assert.AreEqual("not", CalculateMeloneForFriends(11));
        }
        [TestMethod]
        public void casethree()
        {
            Assert.AreEqual("not", CalculateMeloneForFriends(30));
        }

        String CalculateMeloneForFriends(int kilograms)
        {
            kilograms = kilograms / 2;
            if (kilograms % 2 != 0)
                return "not";
            else
            {
                return "yes";
            }
        
        }
    }
}
