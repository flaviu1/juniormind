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
            Assert.IsTrue(IsPanagram("abcdefghijklmnopqrstuvwxyz"));
        }
        [TestMethod]
        public void Test()
        {
            Assert.IsFalse(IsPanagram("tlazy dog "));
        }

        bool IsPanagram(string phrase)
        {
            bool value = true;
            string[] alphabet = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};

            for (int i = 0; i < alphabet.Length ; i++)
            {
                if(!phrase.Contains(alphabet[i]))
                {
                    value = false;
                }
            }
            return value;
        }
    }
}
