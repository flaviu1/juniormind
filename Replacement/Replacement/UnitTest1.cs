using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Replacement
{
    [TestClass]
    public class UnitTest1
    {
       /* [TestMethod]
        public void TestCangeLetterRecursiv()
        {
           Assert.AreEqual("Flavia", ChangeLetterRecursiv("Flaviu", 'u', "a"));
        }
        string ChangeLetterRecursiv(string input, char letterChange, string newLetter)
        {
            if (input.Length > 1)
            {
              
            }
            return "Flavia";
        }*/
        [TestMethod]
        public void TestChangeLetter()
        {
            Assert.AreEqual("Flavia", ChangeLetterNotRecursiv("Flaviu", 'u', "a"));
            Assert.AreEqual("FlaviaFlaviu", ChangeLetterNotRecursiv("Flaviu", 'u', "aFlaviu"));
        }
         
        string ChangeLetterNotRecursiv( string input, char letterChange, string newLetter)
        {
            string result = string.Empty;
            for(int i=0;i<input.Length;i++)
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
