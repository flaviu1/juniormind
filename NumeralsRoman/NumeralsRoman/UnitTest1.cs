using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumeralsRoman
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("L", ConvertnumberRoman(50));

        }
        String ConvertnumberRoman(int number)
        {
            if ((number < 0) || (number > 100)) 
            if (number < 1) return string.Empty;
            if (number >= 100) return "C";
            if (number >= 90) return "XC" ;
            if (number >= 50) return "L" ;
            if (number >= 40) return "XL";
            if (number >= 10) return "X" ;
            if (number >= 9) return "IX" ;
            if (number >= 5) return "V" ;
            if (number >= 4) return "IV";
            if (number >= 1) return "I";
            else return "Empty" ;
        }
    }
}
