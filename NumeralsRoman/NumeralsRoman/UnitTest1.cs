using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumeralsRoman
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("a", Convertnumber(55));
        }
        String Convertnumber(int number)
        {
            return "a";
        }
    }
}
