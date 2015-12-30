using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForNumberRomanWithDrop()
        {
            Assert.AreEqual("MMMDLV", ToRoman(3555));
            Assert.AreEqual("MMMDLV", IntToRoman(3555));
        }
        [TestMethod]
        public void TestForNumberRomanWithDescomposition()
        {
            Assert.AreEqual("MMCMXCIII", ToRoman(2993));
            Assert.AreEqual("MMCMXCIII", IntToRoman(2993));
        }
        public static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900); //EDIT: i've typed 400 instead 900
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }
        public string IntToRoman(int number)
        {
            string[] thou = { "", "M", "MM", "MMM" };
            string[] hun = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string roman = "";
            roman += thou[(int)(number / 1000) % 10];
            roman += hun[(int)(number / 100) % 10];
            roman += ten[(int)(number / 10) % 10];
            roman += ones[number % 10];

            return roman;
        }
    }
}
