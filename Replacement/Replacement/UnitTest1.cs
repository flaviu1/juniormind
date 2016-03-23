using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Replacement
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCangeLetterRecursiv()
        {
            Assert.AreEqual("Flaviaa", ChangeLetterRecursive("Flaviu", 'u', "aa"));
            Assert.AreEqual("aaxxa", ChangeLetterRecursive("uuxxu", 'u', "a"));
        }
        string ChangeLetterRecursive(string input, char letterChange, string newLetter)
        {
            if (input.Length > 0)
            {
                if (input[0] == letterChange) return newLetter + ChangeLetterRecursive(input.Substring(1), letterChange, newLetter);
                return input[0] + ChangeLetterRecursive(input.Substring(1), letterChange, newLetter);
            }
            return input;

        }

        [TestMethod]
        public void TestChangeLettere()
        {
            Assert.AreEqual("Flavia", ChangeLetterNotRecursiv("Flaviu", 'u', "a"));
            Assert.AreEqual("FlaviaFlaviu", ChangeLetterNotRecursiv("Flaviu", 'u', "aFlaviu"));
        }
        string ChangeLetterNotRecursiv(string input, char letterChange, string newLetter)
        {
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == letterChange)
                {
                    result += newLetter;
                }
                else
                    result += input[i];
            }
            return result;
        }
    }
}
