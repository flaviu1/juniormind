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
        public void TestForCategory22()
         {
            Assert.AreEqual(8, CalculatePosible(6));
        }
        int CalculateProbability(int categori)
        {
            int probability=0;
            return probability;
        }
        float CalculatePosible(int categori)
        {
            int number = 49;
            float probability = 1;
            int x=1;
            while(x<=categori)
            {
                probability = probability * (x / number);
                number--;
                x++;
            }
            return probability;
        }
    }
}
