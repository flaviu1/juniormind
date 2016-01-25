using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BinaryConversion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForConversion()
        {
            CollectionAssert.AreEqual(new byte[6] {1,1,0,0,0,1},ConvertBinary(49));
        }
        [TestMethod]
        public void TestForNot()
        {
            CollectionAssert.AreEqual(new byte[6] {0,0,1,1,1,0},NotOperatorsOnByte(49));
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
        byte[] NotOperatorsOnByte(int number)
        {
            byte[] bytes = new byte[6];
            byte n = 0;
            byte[] notbytes=new byte[6];
            byte m=0;
            while (number >= 1)
            {
                bytes[n] = (byte)(number % 2);
                n++;
                number = number / 2;
            }
            for (int i = 0; i < n;i++ )
            {
                if(bytes[i]!=1)
                {
                    bytes[i] = 1;
                }
                else
                    bytes[i]=0;

            }
                Array.Reverse(bytes);
            return bytes;

        }
    }
}