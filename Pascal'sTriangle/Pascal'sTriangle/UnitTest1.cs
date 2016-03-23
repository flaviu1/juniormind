using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pascal_sTriangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(new int[] {0},CalculateTrianglHisPascal(1));
        }

        int[] CalculateTrianglHisPascal(int number)
        {
            int[] result=new int[0];
            return result;
        }
    }
}
