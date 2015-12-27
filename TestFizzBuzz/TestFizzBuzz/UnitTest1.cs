using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForDivizorWithThree()
        {
            Assert.AreEqual("Fizz",CalculateDivizor(6));
        }
        [TestMethod]
        public void TestForDivizorWithFive()
        {
            Assert.AreEqual("Buzz", CalculateDivizor(10));
        }

        string CalculateDivizor(int Number)
        {
            return "a";
        }
    }
}
