using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMelone
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ForKilogramsEven()
        {
            Assert.AreEqual("yes", CalculateMeloneForFriends(10));
        }
        [TestMethod]
        public void ForOdd()
        {
            Assert.AreEqual("not", CalculateMeloneForFriends(11));
        }

        String CalculateMeloneForFriends(int Kilograms)
        {
            if(Kilograms%2==0)
            {
                return "yes" ;
            }
            else
            {
                return "not";
            }
        }
    }
}
