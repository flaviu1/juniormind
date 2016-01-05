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
            Assert.AreEqual(85, CalculateSquare(8));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(191, CalculateSquare(12));
        }
        int CalculateSquare(int n )
        {
            int x=n*n;
            n = n * n;
         do
          {
              n = n / 4;
              x = x+ n;
          } while (n >= 1) ;
          return x;
        }
    }
}
