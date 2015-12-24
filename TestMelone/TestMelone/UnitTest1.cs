using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMelone
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MelonKilograms()
        {
            Assert.AreEqual(5, CalculateMeloneForFriends(10));
        }
        [TestMethod]
        public void ForKilogramsEven()
        {
            Assert.AreEqual(5, CalculateMeloneForFriends(10));
        } 
        public void ForOdd()
        {
            Assert.AreEqual(1, CalculateMeloneForFriends(11));
        }

        int CalculateMeloneForFriends(int Kilograms)
        {
            return Kilograms/2;
        }
    }
}
