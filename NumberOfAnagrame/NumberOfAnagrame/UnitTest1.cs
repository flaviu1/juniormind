using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberOfAnagrame
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, CalculateNumberOfAnagrame("assa"));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(20, CalculateNumberOfAnagrame("qqqwe"));
        }
        [TestMethod]
        int CalculateNumberOfAnagrame(string phrase)
        {
            int product = 1;
            string uniques = string.Empty;
            foreach (char c in phrase)
            {
                if (!Contains(uniques, c))
                {
                    product *= CalculateFactorial(CountChar(phrase, c));
                    uniques += c;
                }
            }
            return CalculateFactorial(phrase.Length) / product;
        }

        private static bool Contains(string uniques, char c)
        {
            return CountChar(uniques, c) > 0;
        }
       
        private static int CountChar(string phrase, char c)
        {
            int counter = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (c == phrase[i])
                    counter++;
            }
            return counter;
        }

        int CalculateFactorial(int number)
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
