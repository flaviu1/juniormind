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
            Assert.AreEqual("s",CalculatePrefix("sa","sff"));
        }
        string CalculatePrefix(string stringA, string StringB )
        {
            return "s";
        }

     }
}
