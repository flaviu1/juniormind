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

        string SearchForPanagram(string phrase )
        {
            for (int i = 0; i <= phrase.Length - 1; i++)
            {
               if(SearchPoint(phrase,phrase[i]));
            }
        }

        Boolean SearchPoint(string alphabet ,char point)
        {
            int contor=0;
            for (int i = 0; i <= alphabet.Length - 1; i++)
            {
                   if(alphabet[i]==point)
                   {
                       return true;
                   }
            }
            return folse;
        }
    }
}
