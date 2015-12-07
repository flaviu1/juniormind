using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, CalculateMusRed(15,2));
            Assert.AreEqual(250, CalculateMusRed(300, 5));
        }

        float CalculateMusRed(int number,int x)
        {
            float a = (number) / (1 + x);
            return number - a;

        }
    }
}
