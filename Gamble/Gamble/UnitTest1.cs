using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gamble
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForCategoryI()
        {
            Assert.AreEqual(8, CalculateProbability(1));
        }
        [TestMethod]
        public void TestForFactorial()
        {
            Assert.AreEqual(40320, CalculateFactorial(8));
        }
        int CalculateProbability(int categori)
        {
            int probability=0;
            return probability;
        }

        int CalculateCombinari(int items ,int submultimi)
        {
            return 1;
        }
        int CalculateFactorial(int number)
        {
            int result = 1;
            for (int i = 1; i < number+1; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
