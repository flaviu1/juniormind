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
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1, 1, 0 }, Not(new byte[] { 1, 1, 0, 0, 0, 1 }));
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
            byte[] bytes = new byte[0];
            int n = 0;
            while (number >= 1)
            {
                Array.Resize(ref bytes, bytes.Length + 1);
                bytes[n] = (byte)(number % 2);
                n++;
                number = number / 2;
            }
            Array.Reverse(bytes);
            return bytes;
        }
        byte[] Not(byte[] bytes)
        {
            byte[] result = new byte[0];
            for (int i = 0; i < bytes.Length; i++)
            {
                Array.Resize(ref result, result.Length + 1);
                result[i] = Not(bytes[i]);
            }
            return result;
        }
        private static byte Not(byte bytes)
        {
            return (bytes != 1) ? (byte)1 : (byte)0;
        }

        [TestMethod]
        public void And()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1 }, And(new byte[] { 0, 1, 0, 1 }, new byte[] { 0, 0, 1, 1 }));
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
            Assert.AreEqual(2, GetDigit(new byte[] { 1, 2, 3, 4 }, 2));
        }
        byte GetDigit(byte[] bytes, int positions)
        {
            if (bytes.Length <= positions)
                return 0;
            return bytes[bytes.Length - positions - 1];

        }


        [TestMethod]
        public void RightHandShift()
        {
            CollectionAssert.AreEqual(new byte[] { 1 }, RightHandShif(new byte[] { 1, 1, 1, 1 }, 3));
            CollectionAssert.AreEqual(new byte[] { 1, 1 }, RightHandShif(new byte[] { 1, 1, 1, 1 }, 2));
        }
        byte[] RightHandShif(byte[] bytes, int positions)
        {
            Array.Resize(ref bytes, bytes.Length - positions);
            return bytes;
        }


        [TestMethod]
        public void LefttHandShift()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 1, 0, 0, 0 }, LefttHandShif(new byte[] { 1, 1, 0, 1 }, 3));
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0 }, LefttHandShif(new byte[] { 1 }, 2));
        }
        byte[] LefttHandShif(byte[] bytes, int positions)
        {
            Array.Resize(ref bytes, bytes.Length + positions);
            return bytes;
        }


        [TestMethod]
        public void Add()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 1, 1, 1, 0 }, Add(new byte[] { 0, 0, 0, 0, 1, 1, 1, 1 }, new byte[] { 0, 1, 1, 1, 1, 1, 1, 1 }));
        }
        byte[] Add(byte[] bytesOne, byte[] bytesTwo)
        {
            Array.Reverse(bytesOne);
            Array.Reverse(bytesTwo);
            byte[] bytesResult = new byte[Math.Max(bytesTwo.Length, bytesOne.Length)];
            int remainder = 0;
            for (int i = 0; i < bytesResult.Length; i++)
            {
                if (bytesOne[i] + bytesTwo[i] + remainder == 3)
                {
                    bytesResult[i] = 1;
                    remainder = 1;
                }
                if (bytesOne[i] + bytesTwo[i] + remainder == 2)
                {
                    bytesResult[i] = 0;
                    remainder = 1;
                }
                if (bytesOne[i] + bytesTwo[i] + remainder == 1)
                {
                    bytesResult[i] = 1;
                }
            }
            Array.Reverse(bytesResult);
            return bytesResult;
        }

        [TestMethod]
        public void Drop()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1, 1, 1, 0, 1 }, Drop(new byte[] { 1, 0, 0, 0, 1, 1, 1, 0 }, new byte[] { 0, 1, 1, 1, 0, 0, 0, 1 }));
        }
        byte[] Drop(byte[] bytesOne, byte[] bytesTwo)
        {
            Array.Reverse(bytesOne);
            Array.Reverse(bytesTwo);
            byte[] bytesResult = new byte[Math.Max(bytesTwo.Length, bytesOne.Length)];
            int counter = 0;
            for (int i = 0; i < bytesResult.Length; i++)
            {
                if (bytesOne[i] - bytesTwo[i] - counter == -1)
                {
                    bytesResult[i] = 1;
                    counter = 1;
                }
                if (bytesOne[i] - bytesTwo[i] - counter == 0)
                {
                    bytesResult[i] = 0;
                    counter = 0;
                    continue;
                }
                if (bytesOne[i] + bytesTwo[i] + counter == 1)
                {
                    bytesResult[i] = 1;
                }
            }
            Array.Reverse(bytesResult);
            return bytesResult;
        }


        [TestMethod]
        public void AddNew()
        {
            CollectionAssert.AreEqual(ToBinary(6), AddNew(ToBinary(3), ToBinary(3)));
        }
        byte[] AddNew(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] bytesResult = new byte[Math.Max(bytesTwo.Length, bytesOne.Length)];
            int remainder = 0;
            for (int i = 0; i < bytesResult.Length; i++)
            {
                bytesResult[i] = (byte)((GetDigit(bytesOne, i) + GetDigit(bytesTwo, i) + remainder) % 2);
                remainder = (GetDigit(bytesOne, i) + GetDigit(bytesTwo, i) + remainder) / 2;
            }
            if (remainder == 1)
            {
                Array.Resize(ref bytesResult, bytesResult.Length + 1);
                bytesResult[bytesResult.Length - 1] = (byte)remainder;
            }
            Array.Reverse(bytesResult);
            return bytesResult;
        }


        [TestMethod]
        public void DropNew()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0, 1, 1, 1, 0, 1 }, DropNew(new byte[] { 1, 0, 0, 0, 1, 1, 1, 0 }, new byte[] { 0, 1, 1, 1, 0, 0, 0, 1 }));
        }
        byte[] DropNew(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] bytesResult = new byte[Math.Max(bytesTwo.Length, bytesOne.Length)];
            int remainder = 0;
            for (int i = 0; i < bytesResult.Length; i++)
            {
                int a = GetDigit(bytesOne, i);
                int b = GetDigit(bytesTwo, i);

                bytesResult[i] = (byte)((a - b - remainder + 2) % 2);
                remainder = (a - b - remainder - 2) / 2;

            }
            Array.Reverse(bytesResult);
            return bytesResult;
        }


        [TestMethod]
        public void LessThan()
        {
            CollectionAssert.AreEqual(ToBinary(4), LessThan(ToBinary(4), ToBinary(7)));
        }
        byte[] LessThan(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] bytesEmpty = new byte[0];
            for (int i = 0; i < Math.Max(bytesOne.Length, bytesTwo.Length); i++)
            {
                if (GetDigit(bytesOne, i) < GetDigit(bytesTwo, i))
                    return bytesOne;
                if (GetDigit(bytesOne, i) > GetDigit(bytesTwo, i))
                    return bytesTwo;
            }
            return bytesEmpty;
        }


        [TestMethod]
        public void GreaterThan()
        {
            CollectionAssert.AreEqual(ToBinary(9), GreaterThan(ToBinary(9), ToBinary(7)));
        }
        byte[] GreaterThan(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] bytesEmpty = new byte[0];
            for (int i = Math.Max(bytesOne.Length, bytesTwo.Length); i > 0; i--)
            {
                if (GetDigit(bytesOne, i) > GetDigit(bytesTwo, i))
                    return bytesOne;
                if (GetDigit(bytesOne, i) < GetDigit(bytesTwo, i))
                    return bytesTwo;
            }
            return bytesEmpty;
        }


        [TestMethod]
        public void Equal()
        {
            Assert.AreEqual(true, Equal(ToBinary(9), ToBinary(9)));
            Assert.AreEqual(false, Equal(ToBinary(9), ToBinary(5)));
        }
        bool Equal(byte[] bytesOne, byte[] bytesTwo)
        {
            for (int i = Math.Max(bytesOne.Length, bytesTwo.Length); i > 0; i--)
            {
                if (GetDigit(bytesOne, i) != GetDigit(bytesTwo, i))
                    return false;
            }
            return true;
        }


        [TestMethod]
        public void NotEqual()
        {
            Assert.AreEqual(true, NotEqual(ToBinary(5), ToBinary(7)));
           Assert.AreEqual(false, NotEqual(ToBinary(9), ToBinary(9)));
        }
        bool NotEqual(byte[] bytesOne, byte[] bytesTwo)
        {
             if (Equal(bytesOne,bytesTwo))
                 return false;
               return true;
        }

        [TestMethod]
        public void calclulateMultiplication()
        {
            Assert.AreEqual(15,calclulateMultiplication(3,5));
        }

        int calclulateMultiplication(int a , int b)
        {
            int result = 0;
            for(int i=0;i<b;i++)
            {
                result = a +result;
            }
            return result;
        }

        [TestMethod]
        public void Multiplication()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1}, Multiplication(new byte[] { 0, 1, 0, 1 }, new byte[] { 0, 0, 1, 1 }));
            CollectionAssert.AreEqual(ToBinary(15), Multiplication(ToBinary(3),ToBinary(5)));
        }

        byte[]  Multiplication(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] result =new byte[Math.Max(bytesTwo.Length,bytesOne.Length)];
            int n = bytesOne.Length+1;
            while (n>0)
            {
                result = AddNew(bytesTwo, result);
                n--;
            }
            return result;
        }


       /* [TestMethod]
        public void Division()
        {
            Assert.AreEqual(5, Division(new byte[] { 1, 0, 1, 0 }, new byte[] { 0, 0, 1,0  }));
            CollectionAssert.AreEqual(ToBinary(5), Division(ToBinary(10), ToBinary(2)));
        }

        byte[] Division(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] result = new byte[Math.Max(bytesTwo.Length, bytesOne.Length)];
            int n = 1;
            byte[] counter = new byte[Math.Max(bytesTwo.Length,bytesOne.Length)];
            while (n == 0)
            {
                counter = DropNew(GreaterThan(bytesOne, bytesTwo),LessThan(bytesOne, bytesTwo));
                n--;
            }
            return counter;
        }*/

    }
}