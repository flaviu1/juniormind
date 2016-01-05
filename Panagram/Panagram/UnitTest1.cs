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
            Assert.AreEqual("it's a panagram", SearchForPanagram("The quick brown fox jumps over the lazy dog"));
        }

        string SearchForPanagram(string phrase )
        {
            int contor = 0;
         string[] alphabet={"abcdefghijklmnopqrstuvwxyz"};
         for (int i = 0; i <= alphabet.Length - 1; i++)
         {
             for (int j = 0; j <= phrase.Length - 1; j++)
             {
                 if (alphabet[i] == phrase[j])
                 {
                     contor=1;
                 }
             }
             if (contor != 1) break;
         }
         if (contor == 1) return "it's a panagram";
         else return "it is not panagram";
        }
    }
}
