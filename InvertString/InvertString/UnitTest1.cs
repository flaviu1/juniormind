using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvertString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInvertString()
        {
            Assert.AreEqual("edcba", InvertString("abcde"));
        }
        string InvertString(string input)
        {
            if (input.Length == 1) return input;
            return input[input.Length - 1] + InvertString(input.Substring(0, input.Length - 1));
        }
    }
}
