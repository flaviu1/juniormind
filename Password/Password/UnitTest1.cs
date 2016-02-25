using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhatSizeePassword()
        {
            Assert.AreEqual(5, GeneratePassword(5).Length);
        }
        [TestMethod]
        public void WhatCountingUppercaseLetter()
        {
            Assert.AreEqual(10, CounteNumbers(GeneratePassword(20, 10, 10)));
        }
        [TestMethod]
        public void WhatsDigitsContainsPassword()
        {
            Assert.AreEqual(10, ContingUppercasePassowrd(GeneratePassword(20, 10)));
        }
        string GeneratePassword(int number , int uppercase=0,int digits=0)
        {
            string result = string.Empty;
            Random rnd = new Random();
            result = ConditionsForPassword(number, uppercase,digits, rnd);
            return result;
        }

        private static string ConditionsForPassword(int number, int uppercase,int digits, Random rnd)
        {
            string result = string.Empty;
            for (int i = 0; i < number - uppercase-digits; i++)
            {
                result += (char)rnd.Next('a', 'z' + 1);
            }
            for (int i = 0; i < uppercase-digits; i++)
            {
                result += (char)rnd.Next('A', 'Z' + 1);
            }
            for (int i = 0; i < digits; i++)
            {
                result +=rnd.Next(0, 9);
            }

            return result;
        }

        [TestMethod]
        public void ManyDigitsContainsThePhrase()
        {
            Assert.AreEqual(3,CounteNumbers("as113"));
            Assert.AreEqual(5, CounteNumbers("a11s113"));
        }
        int CounteNumbers(string word)
        {
            int counter=0;
           foreach(char c in word)
            {
                if (char.IsNumber(c))
                    counter++;
            }
            return counter;
        }

        [TestMethod]
        public void WhatUppercaseContingPassword()
        {
            Assert.AreEqual(2, ContingUppercasePassowrd("aaaaaaAA"));
            Assert.AreEqual(0, ContingUppercasePassowrd("aaaaaa"));
        }
        int ContingUppercasePassowrd(string word)
        {
            int counter = 0;
            foreach(char c in word)
            {
                if (char.IsUpper(c))
                    counter++;
            }
            return counter;
        }
    } 
}

