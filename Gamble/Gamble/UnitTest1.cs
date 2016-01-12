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
        int CalculateProbability(int categori)
        {
            int probability = 1;
            int number;

            while(number==categori)
            {

            }
            return probability;
        }
    }
}
