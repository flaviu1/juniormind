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
            int CalculateDistance=DistanceBird(30,12000);
        }
        int DistanceBird(int speed, int distance)
        {
            int start = 1 / 4 * distance;
            int speedTime = start * 60 / speed;
            return 2 * start;
        }
    }
}
