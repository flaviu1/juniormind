using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gamble
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForFactorial()
        {
            Assert.AreEqual(608281864034267560872252163321295376887552831379210240000000000, CalculateFactorial(49));
        }
        [TestMethod]
        public void TestForCombinations()
        {
            Assert.AreEqual(13983816, CalculateCombinations(49, 6));
        }
       
        int CalculateProbability(int categori)
        {
            int probability=0;
            return probability; 
        }

         double CalculateCombinations(int number1 ,int number2)
        {
            double combinations = 0;
            int drop = number1 - number2;
            return combinations = combinations + CalculateFactorial(number1) / (CalculateFactorial(number2) * CalculateFactorial(drop));
        }

        double CalculateFactorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}