using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pavage
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(36,CalculatePavaje(6,6,1));
           
        }

        int CalculatePavaje(int m, int n, int a)
        {
            int numberOfCubles = (m/a)*(n/a );
            return numberOfCubles;
        }
    }
}
