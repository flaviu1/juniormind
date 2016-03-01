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
            Assert.AreEqual(10, ContingSymbols(GeneratePassword(20, 0, 0, 10)));
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
            string symbolsString = "!#$%&()+,-./:;<>*=?@[_{}]\\";

            result = GeneratePasword((number - uppercase - digits - symbols), rnd, result, 'a', (char)('z' + 1));
            result = GeneratePasword(uppercase, rnd, result, 'A', (char)('Z' + 1));
            result = GeneratePasword(digits, rnd, result, (char)48, (char)(58));
            for (int i = 0; i < symbols; i++)
            {
                result += symbolsString[rnd.Next(symbolsString.Length)];
            }
            return result;
        }

        private static string GeneratePasword(int dimension, Random rnd, string result, char x, char y)
        {
            for (int i = 0; i < dimension; i++)
            {
                result += (char)rnd.Next(x, y);
            }
            return result;
        }

        private static string Generate(int number, int uppercase, int digits, Random rnd, int symbols, string result, char x, char y)
        {
            for (int i = 0; i < number - uppercase - digits - symbols; i++)
            {
                result += (char)rnd.Next(x, y);
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
            string symbolsString = "!#$%&()+,-./:;<>*=?@[_{}]\\";
            for (int i = 0; i < symbols.Length; i++)
                for (int j = 0; j < symbolsString.Length; j++)
                {
                    if (symbols[i] == symbolsString[j])
                    {
                        counter++;
                    }
                }
            return counter;
        }

        [TestMethod]
        public void AmbigueCharacters()
        {
            Assert.AreEqual(true, CheckForAmbiguousCharacters('>'));
            Assert.AreEqual(false, CheckForAmbiguousCharacters('1'));
            Assert.AreEqual(false, CheckForAmbiguousCharacters('g'));
        }
        [TestMethod]
        public void SimilarCharacters()
        {
            Assert.AreEqual(true, CheckForSimilarCharacters('1'));
            Assert.AreEqual(false, CheckForSimilarCharacters('>'));
            Assert.AreEqual(false, CheckForSimilarCharacters('a'));
        }

        bool CheckForAmbiguousCharacters(char character)
        {
            return VerifyCharactersSimilareAmbigue(character, "ambiguous");
        }
        bool CheckForSimilarCharacters(char character)
        {
            return VerifyCharactersSimilareAmbigue(character, "similar");
        }

        private static bool VerifyCharactersSimilareAmbigue(char character, string similarOrAmbigue)
        {
            string symbolsSimilar = "l1Io0O";
            string symbolsAmbiguous = "{}[]()/\'~,;.<>";
            string symbols = string.Empty;
            if (similarOrAmbigue == "ambiguous") symbols = symbolsAmbiguous;
            else symbols = symbolsSimilar;
            for (int i = 0; i < symbols.Length; i++)
            {
                if (character == (char)symbols[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}

