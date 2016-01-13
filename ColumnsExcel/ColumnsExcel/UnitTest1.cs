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
            Assert.AreEqual("A",ConvertColumns(1))
        }
        int ConvertColumns(int comumns)
        {
            return "A";
        }
    }
}
