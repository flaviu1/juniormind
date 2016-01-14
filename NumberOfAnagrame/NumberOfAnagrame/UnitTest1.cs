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
            Assert.AreEqual(6, CalculateNumberOfAnagrame("ssaa"));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(15, CalculateNumberOfAnagrame("qqqwe"));
        }
        [TestMethod]
        int CalculateNumberOfAnagrame(string phrase)
        {
            int contor = 0;
            int subunitary = 0;
            int result = 0;
            char character = ' ';
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == character)
                    continue;
                for (int j = 0; j < phrase.Length; j++)
                {
                    if (phrase[i] == phrase[j])
                        contor++;
                    character = phrase[i];
                }
                subunitary += CalculateFactorial(contor);
                contor = 0;
            }
            return result = CalculateFactorial(phrase.Length) / subunitary;
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
