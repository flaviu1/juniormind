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

         string ConvertColumns(int columns)
        {
            string result = string.Empty;
            string[] alfabet = {" ", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
          while(--columns>0)
          {
              for(int i=1;i<alfabet.Length;i++)
              {
                 // if(columns%26)
              }
          }
                return "s";
        }
    }
}