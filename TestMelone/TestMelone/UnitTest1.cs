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

        int CalculateMeloneForFriends(int Kilograms)
        {
            return Kilograms/2;
        }
    }
}
