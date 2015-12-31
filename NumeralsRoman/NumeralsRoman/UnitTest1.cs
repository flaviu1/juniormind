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
            Assert.AreEqual("MMMCMXCVIII", ToRoman(3998));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("XXXV", ToRoman(35));
        }
        string x;
        string ToRoman(int number)
        {
            int[ ] zecimalnumber = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 ,3000};
            string[ ] romannumber = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M","MMM" };
            int n=13;
            if((number>=1)&&(number<=3999))
                return "Empty";
            else
                {
                 for(int i=zecimalnumber[n]; i>=0 ; i--)
                    {
                         while(number>=zecimalnumber[i])
                         {
                             x=x +romannumber[i];
                             number=number-zecimalnumber[i];
                             n--;
                         }
                     }
                 }
            return x;
            







        /*    while (number >0)
            {
                if ((number < 0) || (number > 3999)) return "Empty";
                if (number >= 3000) { x = x + "MMM"; number = number - 3000; }
                if (number >= 1000) { x = x + "M"; number = number - 1000; }
                if (number >= 900) { x = x + "CM"; number = number - 900; }
                if (number >= 500) { x = x + "D"; number = number - 500; }
                if (number >= 400) { x = x + "CD"; number = number - 400; }
                if (number == 100) { x = x + "C"; number = number - 100; }
                if (number >= 90) { x = x + "XC"; number = number - 90; }
                if (number >= 50) { x = x + "L"; number = number - 50; }
                if (number >= 40) { x = x + "XL"; number = number - 40; }
                if (number >= 20) { x = x + "XX"; number = number - 20; }
                if (number >= 10) { x = x + "X"; number = number - 10; }
                if (number >= 9) { x = x + "IX"; number = number - 9; }
                if (number >= 5) { x = x + "V"; number = number - 5; }
                if (number >= 4) { x = x + "IV"; number = number - 4; }
                if (number >= 1) { x = x + "I"; number = number - 1; }
            }
            return x;*/
        }

    }
}
