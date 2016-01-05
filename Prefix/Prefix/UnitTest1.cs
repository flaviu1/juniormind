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
            Assert.AreEqual("NotIsPrefix", CalculatePrefix("sa", "sff"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("abc", CalculatePrefix("abc", "abc"));
        }
        string x;
        string CalculatePrefix(string stringA, string stringB )
        {
            int a=0;
          while(a!=0)
          {
                if(stringA[a]==stringB[a])
                {
                    x=x+stringA[a];
                    a++;
                }
              else return "NotIsPrefix";
           }
            return x;
        }

     }
}
