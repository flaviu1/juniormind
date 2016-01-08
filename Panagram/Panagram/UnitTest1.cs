using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class UnitTest1
    {
        private bool folse;
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("it is a panagram", SearchForPanagram("the quick brown fox jumps over the lazy dog"));
        }
        string a;
        string SearchForPanagram(string phrase)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int contor=0;
            for (int i = 0; i <= phrase.Length - 1; i++)
            {
                if (SearchPoint(alphabet, phrase[i]) == true) ;
                    contor++;
            }
            if (contor == phrase.Length - 1) a="it is a panagram";
              return a;
        }

        Boolean SearchPoint(string alphabet ,char letter)
        {
            for (int i = 0; i <= alphabet.Length - 1; i++)
            {
                if (alphabet[i] == letter)
                   {
                       return true;
                   }
            }  
             return folse;
        }
    }
}
