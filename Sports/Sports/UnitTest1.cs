using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sports
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(16,calculate(4));
            Assert.AreEqual(49, calculate(7));
        }
        int calculate(int Round)
        {
            return Round * Round ;
        }
    }
}
