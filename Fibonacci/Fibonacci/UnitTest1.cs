using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(13,Fibonacci(7));
        }
        [TestMethod]
        public void FibonacciOf15()
        {
            Assert.AreEqual(610, Fibonacci(15));
        }

        public int Fibonacci(int n)
        {
            if (n <2) return n;
            return (Fibonacci(n-1)+Fibonacci(n-2));
        }

    }
}
