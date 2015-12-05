using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Trains
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int total = CalculateDistance(12);
            Assert.AreEqual(6, total );
        }
        int CalculateDistance(int distance)
             {
                  int bird = 1/2 * distance;
                  return bird;
             }
     }
}
