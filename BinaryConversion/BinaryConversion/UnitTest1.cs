using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BinaryConversion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new byte[6] {1,1,0,0,0,1},ConvertBinary(49));
        }

        byte[] ConvertBinary(int number)
        {
            byte[] bytes = new byte[6];
            byte n = 0;
            while (number >= 1)
            {
                bytes[n] =(byte)(number % 2);
                n++;
                number =number / 2;
            }
            Array.Reverse(bytes);
            return bytes;
        }
    }
}