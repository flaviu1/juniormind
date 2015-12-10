using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parquet
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, CalculateParquet(100, 100, 10, 100));
        }

        int CalculateParquet(int lenghtRoom, int widthRoom, int lenghtParquet, int widthParquet)
        {
            float Board = (lenghtRoom * widthRoom + (15 / 100) * lenghtRoom * widthRoom) / (lenghtParquet * widthParquet);
            return (int)Board;
        }

    }
}
