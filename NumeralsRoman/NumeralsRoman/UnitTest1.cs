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
            Assert.AreEqual("XLV", ConvertnumberRoman(45));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("Empty", ConvertnumberRoman(101));
        }
        string x;
        String ConvertnumberRoman(int number)
        { 
            if ((number < 0) || (number > 100)) return "Empty" ;
            if (number == 100) { x = x + "C";   number = number - 100; }
            if (number >= 90)  { x = x + "XC";  number = number - 90;  }
            if (number >= 50)  { x = x + "L";   number = number - 50;  }
            if (number >= 40)  { x = x + "XL";  number = number - 40;  }
            if (number >= 20)  { x = x + "XX";  number = number - 20;  }
            if (number >= 10)  { x = x + "X";   number = number - 10;  }
            if (number >= 9)   { x = x + "IX";  number = number - 9;   }
            if (number >= 8)   { x = x + "VIII";number = number - 8;   }
            if (number >= 7)   { x = x + "VII"; number = number - 7;   }
            if (number >= 6)   { x = x + "VI";  number = number - 6;   }
            if (number >= 5)   { x = x + "V";   number = number - 5;   }
            if (number >= 4)   { x = x + "IV";  number = number - 4;   }
            if (number >= 3)   { x = x + "III"; number = number - 3;   }
            if (number >= 2)   { x = x + "II";  number = number - 2;   }
            if (number >= 1)   { x = x + "I";   number = number - 1;   }
            return x;
        }
    }
}
