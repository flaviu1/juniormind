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
        string x;
        string CalculatePrefix(string stringA, string stringB)
        {
            for (int i = 0; i < stringA.Length; i++)
            {
                for (int j = 0; j < stringB.Length; j++)
                    if (stringA[i] == stringB[j])
                    {
                        x = x + stringA[i];
                    }
            }
            return x;
        }
    }
  }
