using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColumnsExcel
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("a", ConvertColumns(1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("z", ConvertColumns(26));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("ba", ConvertColumns(53));
        }

        [TestMethod]
        public void GetChartShouldGetZFor25()
        {
            Assert.AreEqual('z', GetChar(25));
        }

        private char GetChar(int p)
        {
            return (char)('a' + p);
        }
        string ConvertColumns(int columns)
        {
            string result = string.Empty;
            while (--columns >= 0)
            {
                result = GetChar(columns % 26) + result;
                columns = columns / 26;
            }
            return result;
        }
    }
}