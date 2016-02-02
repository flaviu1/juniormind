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
        [TestMethod]
        public void TestForOperatorOr()
        {
            CollectionAssert.AreEqual(new byte[4] { 0, 1, 1, 1 }, OrOperatorsOnByte(new byte[4] { 0, 1, 0, 1 }, new byte[4] { 0, 0, 1, 1 }));
        }
        [TestMethod]
        public void TestForOperatorXor()
        {
            CollectionAssert.AreEqual(new byte[4] { 0, 1, 1, 0 }, XorOperatorsOnByte(new byte[4] { 0, 1, 0, 1 }, new byte[4] { 0, 0, 1, 1 }));
        }
        [TestMethod]
        public void ShiftLeft()
        {
            CollectionAssert.AreEqual(new byte[1] { 1}, ShiftLeftOperatorsOnByte(new byte[4] { 1, 1, 1, 1 }, 3));
            CollectionAssert.AreEqual(new byte[2] { 1,1 }, ShiftLeftOperatorsOnByte(new byte[4] { 1, 1, 1, 1 }, 2));
            CollectionAssert.AreEqual(new byte[0] {  }, ShiftLeftOperatorsOnByte(new byte[4] { 1, 1, 1, 1 }, 4));
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
        byte[] AndOperatorsOnByte(byte[] bytesOne,byte[] bytesTwo)
        {
            byte[] bytes3 = new byte[Math.Max(bytesOne.Length, bytesTwo.Length)];
            for (int i = 0; i < Math.Max(bytesOne.Length, bytesTwo.Length); i++)
            {
                if (bytesOne[i] != 0 && bytesTwo[i] != 0)
                    bytes3[i] = 1;
                else
                bytes3[i] = 0;
            }              
            return bytes3;
        }
        byte[] OrOperatorsOnByte(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] bytes3 = new byte[Math.Max(bytesOne.Length, bytesTwo.Length)];
            for (int i = 0; i < Math.Max(bytesOne.Length, bytesTwo.Length); i++)
            {
                if (bytesOne[i] == 1 || bytesTwo[i] == 1)
                    bytes3[i] = 1;
                else
                bytes3[i] = 0;
            } 
            return bytes3;
        }
        byte[] XorOperatorsOnByte(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] bytes3 = new byte[Math.Max(bytesOne.Length, bytesTwo.Length)];
            for (int i = 0; i < Math.Max(bytesOne.Length, bytesTwo.Length); i++)
             {
                 if (bytesOne[i] == bytesTwo[i])
                     bytes3[i] = 0;
                 else
                     bytes3[i] = 1;
             }
             return bytes3;
        }
        byte[] ShiftLeftOperatorsOnByte(byte[] bytesOne, int positions)
        {
            byte[] bytes2 = new byte[bytesOne.Length-positions];
            for (int i = bytesOne.Length-positions; i > 0; i--)
            {
                bytes2[i-1] = bytesOne[i];
            }
                return bytes2;
        }
    }   
}