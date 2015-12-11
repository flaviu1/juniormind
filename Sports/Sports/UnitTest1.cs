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
            Assert.AreEqual(16,Calculate(4));
        }
        int Calculate(int round)
        {
            return round * round ;
        }
    }
}
