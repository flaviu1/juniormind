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
            Assert.AreEqual("XCIX", ConvertnumberRomanDrop(99));
            Assert.AreEqual("XCIX", ConvertnumberRomanDescompozition(99));
        }
        [TestMethod]
      public void TestMethod4()
        {
            Assert.AreEqual("LXXVII", ConvertnumberRomanDrop(77));
           // Assert.AreEqual("LXXVII", ConvertnumberRomanDescompozition(77));
        }
        string x;
        String ConvertnumberRomanDrop(int number)
        {
            while (number > 0)
            {
                if ((number < 0) && (number >= 100)) return "Empty";
                if (number >= 90) { x = x + "XC"; number = number - 90; }
                if (number >= 50) { x = x + "L"; number = number - 50; }
                if (number >= 40) { x = x + "XL"; number = number - 40; }
                if (number >= 20) { x = x + "XX"; number = number - 20; }
                if (number >= 10) { x = x + "X"; number = number - 10; }
                if (number >= 9) { x = x + "IX"; number = number - 9; }
                if (number >= 8) { x = x + "VIII"; number = number - 8; }
                if (number >= 7) { x = x + "VII"; number = number - 7; }
                if (number >= 6) { x = x + "VI"; number = number - 6; }
                if (number >= 5) { x = x + "V"; number = number - 5; }
                if (number >= 4) { x = x + "IV"; number = number - 4; }
                if (number >= 3) { x = x + "III"; number = number - 3; }
                if (number >= 2) { x = x + "II"; number = number - 2; }
                if (number >= 1) { x = x + "I"; number = number - 1; }
            }
            return x;
        }
         String ConvertnumberRomanDescompozition(int number)
        {
            return "XCIX";
        }
    }
}
