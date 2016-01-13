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
            Assert.AreEqual(608281864034267560872252163321295376887552831379210240000000000d, CalculateFactorial(49));
        }
        [TestMethod]
        public void TestForCombinations()
        {
            Assert.AreEqual(13983816, CalculateCombinations(49, 6));
        }
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(0.00000007d,0.00000007d,(double)CalculateProbability(1));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual( 0.00001845d,0.00001845d, (double)CalculateProbability(2));
        }
        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(0.00096861d, 0.00096861d, (double)CalculateProbability(3));
        }
        double CalculateProbability(int categori)
        {
            double probability = 0;
            if(categori==1)
                probability+=CalculateCombinations(6,6)*CalculateCombinations(43,0)/CalculateCombinations(49,6);
            if (categori == 2)
                probability += CalculateCombinations(6, 5)*CalculateCombinations(43,1)/CalculateCombinations(49,6);
            if (categori == 3)
                probability += CalculateCombinations(6, 4) * CalculateCombinations(43, 2) / CalculateCombinations(49, 6);
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
            double result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}