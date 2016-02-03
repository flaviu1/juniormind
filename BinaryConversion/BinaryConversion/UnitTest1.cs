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
            CollectionAssert.AreEqual(new byte[] { 1,1,0,0,0,1 }, ConvertBinary(49));
        }
        [TestMethod]
        public void TestForOperatorNot()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1, 1, 0 }, NotOperatorsOnByte( new byte[] {1,1,0,0,0,1} ));
        }
        [TestMethod]
        public void TestForOperatorAnd()
        {
            CollectionAssert.AreEqual(new byte[] {  0, 0, 0, 1 }, AndOperatorsOnByte(new byte[] { 0, 1, 0, 1 }, new byte[4] { 0, 0, 1, 1 }));
        }
        [TestMethod]
        public void TestForOperatorOr()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1, 1 }, OrOperatorsOnByte(new byte[] { 0, 1, 0, 1 }, new byte[4] { 0, 0, 1, 1 }));
        }
        [TestMethod]
        public void TestForOperatorXor()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1, 0 }, XorOperatorsOnByte(new byte[] { 0, 1, 0, 1 }, new byte[4] { 0, 0, 1, 1 }));
        }
      /*  [TestMethod]
        public void ShiftLeft()
        {
            CollectionAssert.AreEqual(new byte[] { 1,0,0,0 }, ShiftLeft(new byte[] { 0, 0, 0, 1 }, 3));
            CollectionAssert.AreEqual(new byte[2] { 1, 1 }, ShiftLeft(new byte[4] { 1, 1, 1, 1 }, 2));
            CollectionAssert.AreEqual(new byte[0] { }, ShiftLeft(new byte[4] { 1, 1, 1, 1 }, 4));
        }*/


     
        byte[] ConvertBinary(int number)
        {
            byte[] bytes = ConvertNumber(number);
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
        private static byte[] ConvertNumber(int number)
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
            byte[] bytesAnd = new byte[Math.Max(bytesOne.Length, bytesTwo.Length)];
            return bytesAnd=VerifyConditions(bytesOne,bytesTwo,bytesAnd,"And");
        }
        byte[] OrOperatorsOnByte(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] bytesOr = new byte[Math.Max(bytesOne.Length, bytesTwo.Length)];
            return bytesOr = VerifyConditions(bytesOne, bytesTwo, bytesOr,"Or");
        }
        byte[] XorOperatorsOnByte(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] bytesXor = new byte[Math.Max(bytesOne.Length, bytesTwo.Length)];
            return bytesXor = VerifyConditions(bytesOne, bytesTwo,bytesXor,"Xor");
        }
        byte[] VerifyConditions(byte[] bytesOne, byte[] bytesTwo,byte[] bytesLenght, string operatorr)
        {
            byte[] result = new byte[bytesLenght.Length];
            for (int i = 0; i < result.Length; i++)
            {
                if (operatorr == "And")
                {
                    if (bytesOne[i] == 1 && bytesTwo[i] == 1)
                        result[i] = 1;
                    else
                        result[i] = 0;
                }
                if (operatorr =="Or")
                {
                    if (bytesOne[i] == 1 || bytesTwo[i] == 1)
                        result[i] = 1;
                    else
                        result[i] = 0;
                }
                if (operatorr =="Xor")
                {
                    if (bytesOne[i] != bytesTwo[i])
                        result[i] = 1;
                    else
                        result[i] = 0;
                }
            }

            return result;
        }

      /*  byte[] ShiftLeft(byte[] bytesOne, int positions)
        {
            byte[] bytes2 = new byte[bytesOne.Length];
            for (int i = positions; i < bytesOne.Length; i++)
            {
                bytes2[i] = bytesOne[i];
            }
            return bytes2;*/
        }
    }   
