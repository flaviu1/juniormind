using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessBoard
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(64, CalculateSquare(8));
        }
        int CalculateSquare(int n )
        {
            return n * n;
        }
    }
}
