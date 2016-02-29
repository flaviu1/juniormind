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
            Assert.AreEqual(9, CounteNumbers(GeneratePassword(20, 10, 9)));
        }
        [TestMethod]
        public void WhatsDigitsContainsPassword()
        {
            Assert.AreEqual(9, ContingUppercasePassowrd(GeneratePassword(20, 9)));
        }
        [TestMethod]
        public void ManySymbolsContainsPassword()
        {
            Assert.AreEqual(10, ContingSymbols(GeneratePassword(20, 5,5,10)));
        }

        string GeneratePassword(int number, int uppercase = 0, int digits = 0, int symbols = 0)
        {
            string result = string.Empty;
            Random rnd = new Random();
            result = ConditionsForPassword(number, uppercase, digits, rnd, symbols);
            return result;
        }

        private static string ConditionsForPassword(int number, int uppercase, int digits, Random rnd, int symbols)
        {
            string result = string.Empty;
            for (int i = 0; i < number - uppercase - digits - symbols; i++)
            {
                result += (char)rnd.Next('a', 'z' + 1);
            }
            for (int i = 0; i < uppercase; i++)
            {
                result += (char)rnd.Next('A', 'Z' + 1);
            }
            for (int i = 0; i < digits; i++)
            {
                result += rnd.Next(0, 9);
            }
            for (int i = 0; i < symbols; i++)
            {
                result += (char)rnd.Next(33, 47);
            }

            return result;
        }

        [TestMethod]
        public void ManyDigitsContainsThePhrase()
        {
            Assert.AreEqual(3, CounteNumbers("as113"));
            Assert.AreEqual(5, CounteNumbers("a11s113"));
        }
        int CounteNumbers(string word)
        {
            int counter = 0;
            foreach (char c in word)
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
            foreach (char c in word)
            {
                if (char.IsUpper(c))
                    counter++;
            }
            return counter;
        }

        [TestMethod]
        public void HowManySymbolsContains()
        {
            Assert.AreEqual(5, ContingSymbols("*+-()asd"));
        }
        int ContingSymbols(string symbols)
        {
            int counter = 0;
            for (int i = 0; i < symbols.Length; i++)
                for (int j = 33; j <= 47; j++)
                {
                    if (symbols[i] == j)
                    {
                        counter++;
                    }
                }
            return counter;
        }


        bool CheckIsNotAmbiguousCharacters(char character)
        {
            byte[] symbolsAmbigue = { 123, 125, 91, 93, 40, 41, 47, 92, 39, 34, 126, 44, 59, 46, 60, 62 };//numbers is ambiguous characters: "{}[]()/\'"~,;.<>".
            for (int i = 0; i < symbolsAmbigue.Length;i++)
               {
                    if(character==(char)symbolsAmbigue[i])
                    {
                        return true;
                    }
               }
                return false;
        }

        bool CheckForSimilarCharacters(char character)
        {
            byte[] symbolsSimilar = { 108, 49, 73, 111, 48, 79 };//numbers is Similar characters: " l, 1, I, o, 0, O";.
            for (int i = 0; i < symbolsSimilar.Length; i++)
            {
                if (character == (char)symbolsSimilar[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}

