using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberCubEnd888
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(192, CalculateCub(1));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(442, CalculateCub(2));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1192, CalculateCub(5));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(0, CalculateCub(0));
        }

        long CalculateCub(int number)
        {
            int contor = 0;
            int x = 0;
            if (number == 0)
            {
                return 0;
            }
            for (int i = 0; i < 100000; i++)
                if (EndNumberCube(i) == true)
                {
                    contor = contor + 1;
                    x = i;
                    if (contor == number)
                        break;
                }

            return x;
        }

        bool EndNumberCube(int number)
        {
            int x = number * number * number;
            if (x > 888)
            {
                x = x % 1000;
            }
            if (x == 888)
                return true;

            return false;
        }
    }
}

