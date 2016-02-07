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
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0, 0, 1 }, ToBinary(49));
        }
        [TestMethod]
        public void Not()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1, 1, 0 }, Not(ToBinary(49)));
        }
        [TestMethod]
        public void And()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1 }, And(new byte[] { 0, 1, 0, 1 }, new byte[] { 0, 0, 1, 1 }));
        }
        [TestMethod]
        public void Or()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1, 1 }, Or(new byte[] { 0, 1, 0, 1 }, new byte[] { 0, 0, 1, 1 }));
        }
        [TestMethod]
        public void TestForOperatorXor()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1, 0 }, Xor(new byte[] { 0, 1, 0, 1 }, new byte[] { 0, 0, 1, 1 }));
        }


        byte[] ToBinary(int number)
        {
            byte[] bytes = new byte[6];
            int n = 0;
            while (number >= 1)
            {
                bytes[n] = (byte)(number % 2);
                n++;
                number = number / 2;
            }
            Array.Reverse(bytes);
            return bytes;
        }
        byte[] Not(byte[] bytes)
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
        byte[] And(byte[] bytesOne, byte[] bytesTwo)
        {
            return VerifyConditions(bytesOne, bytesTwo, "And");
        }
        byte[] Or(byte[] bytesOne, byte[] bytesTwo)
        {
            return VerifyConditions(bytesOne, bytesTwo, "Or");
        }
        byte[] Xor(byte[] bytesOne, byte[] bytesTwo)
        {
            return VerifyConditions(bytesOne, bytesTwo, "Xor");
        }
        byte[] VerifyConditions(byte[] bytesOne, byte[] bytesTwo, string operatorr)
        {
            byte[] result = new byte[Math.Max(bytesOne.Length, bytesTwo.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Condition(bytesOne[i], bytesTwo[i], operatorr);
            }
            return result;
        }
        byte Condition(byte bytesOne, byte bytesTwo, string operatorr)
        {
            if (operatorr == "And")
                return (bytesOne == 1) && (bytesTwo == 1) ? (byte)1 : (byte)0;
            if (operatorr == "Or")
                return (bytesOne == 1) || (bytesTwo == 1) ? (byte)1 : (byte)0;
            if (operatorr == "Xor")
                return bytesOne != bytesTwo ? (byte)1 : (byte)0;
            return 0;
        }
        [TestMethod]
        public void GetDigit()
        {
            Assert.AreEqual(0, GetDigit(new byte[] { 1, 2, 3, 4 }, 10));
        }
        byte GetDigit(byte[] bytes, int positions)
        {
            if (bytes.Length < positions)
                return 0;
            byte bytesOne = bytes[bytes.Length - positions - 1];
            return bytesOne;
        }
        [TestMethod]
        public void RightHandShif()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1 }, RightHandShif(new byte[] { 1, 1, 1, 1 }, 3));
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1 }, RightHandShif(new byte[] { 1, 1, 1, 1 }, 2));
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 0 }, RightHandShif(new byte[] { 1, 1, 1, 1 }, 100));
        }

        byte[] RightHandShif(byte[] bytes, int positions)
        {
            byte[] bytesOne = new byte[0];
            bytesOne = Shift(bytes, positions, bytesOne);

            Array.Reverse(bytesOne);
            for (int j = 0; j < bytes.Length; j++)
                bytes[j] = bytesOne[j];
            return bytes;
        }
        [TestMethod]
        public void LefttHandShif()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 1, 0, 0, 0 }, LefttHandShif(new byte[] { 1, 1, 0, 1 }, 3));
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 1, 0 }, LefttHandShif(new byte[] { 1, 1, 0, 1 }, 1));
        }

        byte[] LefttHandShif(byte[] bytes, int positions)
        {
            byte[] bytesOne = new byte[0];
            bytesOne = Shift(bytes, positions, bytesOne);
            return bytesOne;
        }

        private static byte[] Shift(byte[] bytes, int positions, byte[] bytesOne)
        {
            for (int i = 0; i < bytes.Length + positions; i++)
            {
                Array.Resize(ref bytesOne, bytesOne.Length + 1);
                if (bytesOne.Length > bytes.Length)
                    bytesOne[i] = 0;
                else
                    bytesOne[i] = bytes[i];
            }
            return bytesOne;
        }
    }
}