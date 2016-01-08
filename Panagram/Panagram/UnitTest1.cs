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
            Assert.AreEqual("it is a panagram",IsPanagram("abcdefghijklmnopqrstuvwxyz"));
        }
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual("it is not panagram", IsPanagram("tlazy dog "));
        }
        string IsPanagram(string phrase)
        {
            int x = 0;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < alphabet.Length ; i++)
             for (int j = 0; j < phrase.Length ;j++ )
                {
                    if (alphabet[i] == phrase[j])
                        x = x + 1;
                          break;
                }
            if (x != alphabet.Length) return "it is not panagram";
            else return "it is a panagram";
        }

       /* bool Contains(string phrase, char toFind)   
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < phrase.Length; i++)
            {
               if(letter != alphabet[i])
                    return false;
            }
            return true;
        }*/
    }
}
