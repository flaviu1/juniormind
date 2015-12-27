using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForDivizorWithThree()
        {
            Assert.AreEqual("Fizz",CalculateDivizor(6));
        }
        [TestMethod]
        public void TestForDivizorWithFive()
        {
            Assert.AreEqual("Buzz", CalculateDivizor(10));
        }
        [TestMethod]
        public void TestForDivizorWithFiveEndThree()
        {
            Assert.AreEqual("FizzBuzz", CalculateDivizor(30));
        }

       String CalculateDivizor( int Number )
        {   
            if (Number % 3 == 0) return "Fizz" ;
            if (Number % 5 == 0) return "Buzz" ;
            if ((Number % 3 == 0) && (Number % 5 == 0)) return "FizzBuzz" ;
            return "a"; //dc daca nu pun un retur imi da eroare? numa asa am reusit sa fac sa mearga sau daca pun un else
        } 
    }
}
