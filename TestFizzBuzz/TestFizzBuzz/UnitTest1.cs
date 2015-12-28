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
            Assert.AreEqual("Fizz", SolveFizzBuzz(6));
        }
        [TestMethod]
        public void TestForDivizorWithFive()
        {
            Assert.AreEqual("Buzz", SolveFizzBuzz(10));
        }
        [TestMethod]
        public void TestForDivizorWithFiveEndThree()
        {
            Assert.AreEqual("FizzBuzz", SolveFizzBuzz(30));
        }
        [TestMethod]
        public void TestForNotDividedEvenFiveThree()
            {
                Assert.AreEqual("it is not divisible with five and three", SolveFizzBuzz(4));
        }
        String SolveFizzBuzz(int number)
       {
            if (IsDivisible(number, 3) && IsDivisible(number, 5)) return "FizzBuzz";
            if (IsDivisible(number, 3)) return "Fizz" ;
            if (IsDivisible(number, 5))  return "Buzz";
            return "it is not divisible with five and three";
        }

       bool IsDivisible(int number, int divisor)
       {
           return number % divisor == 0;
       }
    }
}
