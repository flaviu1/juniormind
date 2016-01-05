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
            Assert.AreEqual(21, CalculateSquare(4));
        }
        int CalculateSquare(int n )
        {
            int contor=n*n;
            n = n * n;
         do
          {
              n = n / 4;
              contor += n;
          } while (n >= 1) ;
         return contor;
        }
    }
}
