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
            Assert.AreEqual("C", ConvertnumberRoman(100));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("L", ConvertnumberRoman(50));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("X", ConvertnumberRoman(10));
        }
        String ConvertnumberRoman(int number)
        {
            if ((number < 0) || (number > 100)) 
            if (number < 1) return string.Empty;
            if (number >= 100) { return "C"; number = number - 100; }
            if (number >= 90) { return "XC"; number = number - 90; }
            if (number >= 50){ return "L"; number = number - 50 ;}
            if (number >= 40) {return "XL"; number = number - 40;}
            if (number >= 10) {return "X"; number = number - 10;}
            if (number >= 9) {return "IX"; number = number - 9;}
            if (number >= 5) {return "V"; number = number - 5;}
            if (number >= 4) {return "IV"; number = number - 4;}
            if (number >= 1) {return "I"; number=number- 1;}
            else return "Empty" ;
        }
    }
}
