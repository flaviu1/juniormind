﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumeralsRoman
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("MMMCMXCVIII", ToRoman(3998));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("XXXV", ToRoman(35));
        }
        [TestMethod]
        public void TestForBiggerNumber3999()
        {
            Assert.AreEqual("Empty", ToRoman(4200));
        }
        string result;
        string ToRoman(int number)
        {
            int[ ] decimalNumber = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[ ] romanNumber = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"};
            if ((number >= 1) && (number <= 3999))
            {
                for (int i = decimalNumber.Length - 1; i >= 0; i--)
                {
                    for (; number >= decimalNumber[i]; number -= decimalNumber[i])
                        result += romanNumber[i];
                }
            }
            else
                return "Empty";

            return result;
        }

    }
}
