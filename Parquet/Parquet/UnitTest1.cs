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
            Assert.AreEqual(10,CalculateParquet(100, 100, 10, 100));
        }

        float CalculateParquet(int lenghtRoom, int widthRoom, int lenghtParquet, int widthParquet)
        {

            float squareFeet = (lenghtRoom * widthRoom);
            float squareParquet = (lenghtParquet * widthParquet);
            float loss = (15 / 100) * lenghtRoom * widthRoom;
            float Board = (squareFeet + loss) / (squareParquet);
            return Board;
        }

    }
}
