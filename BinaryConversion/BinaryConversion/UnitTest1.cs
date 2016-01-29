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
            CollectionAssert.AreEqual(new byte[6] { 1,1,0,0,0,1 }, ConvertBinary(49));
        }
        [TestMethod]
        public void TestForOperatorNot()
        {
            CollectionAssert.AreEqual(new byte[6] { 0, 0, 1, 1, 1, 0 }, NotOperatorsOnByte( new byte[6] {1,1,0,0,0,1} ));
        }
        [TestMethod]
        public void TestForOperatorAnd()
        {
            CollectionAssert.AreEqual(new byte[4] {  0, 0, 0, 1 }, AndOperatorsOnByte(new byte[4] { 0, 1, 0, 1 }, new byte[4] { 0, 0, 1, 1 }));
        }
        byte[] ConvertBinary(int number)
        {
            byte[] bytes = ConvertBinary(ref number);
            Array.Reverse(bytes);
            return bytes;
        }
        byte[] NotOperatorsOnByte(byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] != 1)
                {
                    bytes[i] = 1;
                }
                else
                    bytes[i] = 0;
            }
            return bytes;
        }
        private static byte[] ConvertBinary(ref int number)
        {
            byte[] bytes = new byte[6];
            byte n = 0;
            while (number >= 1)
            {
                bytes[n] = (byte)(number % 2);
                n++;
                number = number / 2;
            }
            return bytes;
        }
        byte[] AndOperatorsOnByte(byte[] bytes1,byte[] bytes2)
        {
            byte[] bytes3=new byte[Math.Max(bytes1.Length,bytes2.Length)];
            for (int i = 0; i < Math.Max(bytes1.Length, bytes2.Length); i++)
            {
                if (bytes1[i] != 0 &&  bytes2[i]!=0)
                    bytes3[i] = 1;
                else
                bytes3[i] = 0;
            }              
            return bytes3;
        }
    }   
}