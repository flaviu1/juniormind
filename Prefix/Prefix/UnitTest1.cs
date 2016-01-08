using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefix
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("s", CalculatePrefix("sa", "sff"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("abc", CalculatePrefix("abc", "abc"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("ab", CalculatePrefix("abc", "ab"));
        }
        string CalculatePrefix(string stringA, string stringB)
        {
            string x = string.Empty;

            for (int i = 0; i < Math.Min(stringA.Length, stringB.Length); i++)
            {
                if (stringA[i] == stringB[i])
                {
                    x = x + stringA[i];
                }
            }
            return x;
        }
    }
}

