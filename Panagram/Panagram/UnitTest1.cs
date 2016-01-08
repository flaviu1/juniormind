using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForPanagram()
        {
            Assert.AreEqual("it is a panagram", SearchForPanagram("the quick brown fox jumps over the lazy dog"));
        }
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("it is not panagram", SearchForPanagram("tlazy dog "));
        }
        string SearchForPanagram(string phrase)
        {
            for (int i = 0; i < phrase.Length ; i++)
            {
                if (SearchPoint(phrase[i]) != true)
                    return "it is not panagram";
            }
            return "it is a panagram";
        }

        Boolean SearchPoint(char letter)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < alphabet.Length; i++)
            {
               if(letter != alphabet[i])
                    return false;
            }
            return true;
        }
    }
}
