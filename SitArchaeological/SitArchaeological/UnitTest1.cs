using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SitArchaeological
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(12,CalculateAriaMinimum(0,0,3,0,0,4));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(35, CalculateAriaMinimum(0, 0, 5, 0, 0, 7));
        }

        int CalculateAriaMinimum(int ax , int ay , int bx , int by , int cx , int cy )
        {
            return (ax*by*1+bx*cy*1+cx*ay*1-by*cx-cy*ax-ay*bx);
        }
    }
}
