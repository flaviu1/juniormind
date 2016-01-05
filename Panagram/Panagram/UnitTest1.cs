using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("it is a panagram", SearchForPanagram("the quick brown fox jumps over the lazy dog"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("it is not panagram", SearchForPanagram("sada"));
        }

        string SearchForPanagram(string phrase )
        {
         int contor =0;
         string alphabet="abcdefghijklmnopqrstuvwxyz";
         for (int i = 0; i <= alphabet.Length - 1; i++)
         {
             for (int j = 0; j <= phrase.Length - 1; j++)
             {
                 if (alphabet[i] == phrase[j])
                 {
                     contor+=1;
                     break;
                 }
             }
             if (contor != 1) break;
         }
         if (contor == 1) return "it is a panagram";
         else return "it is not panagram";
        }
    }
}
