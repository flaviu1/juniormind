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
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0, 0, 1 }, ToBinary(49, 2));
        }
        [TestMethod]
        public void Not()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1, 1, 0 }, Not(new byte[] { 1, 1, 0, 0, 0, 1 }));
        }
        [TestMethod]
        public void Or()
        {
            CollectionAssert.AreEqual(ToBinary(7, 2), Or(ToBinary(5, 2), ToBinary(3, 2)));
        }
        [TestMethod]
        public void TestForOperatorXor()
        {
            CollectionAssert.AreEqual(ToBinary(6, 2), Xor(ToBinary(5, 2), ToBinary(3, 2)));
        }


        byte[] ToBinary(int number, int radix=2)
        {
            byte[] bytes = new byte[0];
            int n = 0;
            while (number >= 1)
            {
                Array.Resize(ref bytes, bytes.Length + 1);
                bytes[n] = (byte)(number % radix);
                n++;
                number = number / radix;
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
            CollectionAssert.AreEqual(ToBinary(10, 2), And(ToBinary(10, 2), ToBinary(10, 2)));
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
                result[i] = Condition(GetDigit(bytesOne, i), GetDigit(bytesTwo, i), operatorr);
            }
            Array.Reverse(result);
            result = ResizesIfTheFirstDigitAndZero(result);
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
            Assert.AreEqual(4, GetDigit(new byte[] { 1, 2, 3, 4 }, 0));
            Assert.AreEqual(0, GetDigit(new byte[] { 1, 2, 3, 4 }, 4));
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
            CollectionAssert.AreEqual(ToBinary(1, 2), RightHandShif(ToBinary(15, 2), 3));
            CollectionAssert.AreEqual(ToBinary(3, 2), RightHandShif(ToBinary(15, 2), 2));
            CollectionAssert.AreEqual(new byte[] { 0, 1 }, RightHandShif(new byte[] { 0, 0, 0, 1 }, 2));
        }
        byte[] RightHandShif(byte[] bytes, int positions)
        {
            Array.Reverse(bytes);
            Array.Resize(ref bytes, bytes.Length - positions);
            Array.Reverse(bytes);
            return bytes;
        }

        [TestMethod]
        public void LefttHandShift()
        {
            CollectionAssert.AreEqual(ToBinary(10, 2), LefttHandShif(ToBinary(5, 2), 1));
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0 }, LefttHandShif(new byte[] { 1 }, 2));
        }
        byte[] LefttHandShif(byte[] bytes, int positions)
        {
            Array.Resize(ref bytes, bytes.Length + positions);
            return bytes;
        }

        [TestMethod]
        public void AddNew()
        {
            CollectionAssert.AreEqual(ToBinary(6, 2), AddNew(ToBinary(3, 2), ToBinary(3, 2)));
            CollectionAssert.AreEqual(ToBinary(117, 2), AddNew(ToBinary(111, 2), ToBinary(6, 2)));
            CollectionAssert.AreEqual(ToBinary(6, 2), AddNew(ToBinary(0, 2), ToBinary(6, 2)));
            CollectionAssert.AreEqual(ToBinary(8, 2), AddNew(ToBinary(4, 2), ToBinary(4, 2)));
            CollectionAssert.AreEqual(new byte[] { 8 }, AddNew(ToBinary(4, 33), ToBinary(4, 33), 33));
            CollectionAssert.AreEqual(ToBinary(2, 200), AddNew(ToBinary(1, 200), ToBinary(1, 200), 200));
        }
        byte[] AddNew(byte[] bytesOne, byte[] bytesTwo, int radix = 2)
        {
            byte[] bytesResult = new byte[Math.Max(bytesTwo.Length, bytesOne.Length)];
            int remainder = 0;
            for (int i = 0; i < bytesResult.Length; i++)
            {
                var sum = (GetDigit(bytesOne, i) + GetDigit(bytesTwo, i) + remainder);
                bytesResult[i] = (byte)(sum % radix);
                remainder = sum / radix;
            }
            Array.Reverse(bytesResult = AddResizeWhitOne(bytesResult, remainder));
            return bytesResult;
        }
        private static byte[] AddResizeWhitOne(byte[] bytesResult, int remainder)
        {
            if (remainder == 1)
            {
                Array.Resize(ref bytesResult, bytesResult.Length + 1);
                bytesResult[bytesResult.Length - 1] = (byte)remainder;
            }
            return bytesResult;
        }

        [TestMethod]
        public void DropNew()
        {
            CollectionAssert.AreEqual(ToBinary(12, 2), Subtraction(ToBinary(15, 2), ToBinary(3, 2)));
            CollectionAssert.AreEqual(ToBinary(9, 2), Subtraction(ToBinary(12, 2), ToBinary(3, 2)));
            CollectionAssert.AreEqual(ToBinary(6, 2), Subtraction(ToBinary(9, 2), ToBinary(3, 2)));
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0 }, Subtraction(new byte[] { 0, 0, 1, 1, 1 }, new byte[] { 0, 0, 0, 0, 1 }));
            CollectionAssert.AreEqual(new byte[] { }, Subtraction(new byte[] { 1, 0 }, new byte[] { 1, 0 }));
            CollectionAssert.AreEqual(ToBinary(1, 2), Subtraction(ToBinary(2, 2), ToBinary(1, 2)));
            CollectionAssert.AreEqual(ToBinary(1, 150), Subtraction(ToBinary(2, 150), ToBinary(1, 150), 150));
        }
        byte[] Subtraction(byte[] bytesOne, byte[] bytesTwo, int radix = 2)
        {
            byte[] bytesResult = new byte[Math.Max(bytesTwo.Length, bytesOne.Length)];
            int remainder = 0;
            for (int i = 0; i < bytesResult.Length; i++)
            {
                var decrease = radix + GetDigit(bytesOne, i) - GetDigit(bytesTwo, i) - remainder;
                bytesResult[i] = (byte)(decrease % radix);
                remainder = (decrease < radix) ? 1 : 0;

            }
            Array.Reverse(bytesResult);
            bytesResult = ResizesIfTheFirstDigitAndZero(bytesResult);
            return bytesResult;
        }

        [TestMethod]
        public void CounterZero()
        {
            CollectionAssert.AreEqual(new byte[] { 1 }, ResizesIfTheFirstDigitAndZero(new byte[] { 0, 0, 0, 1 }));
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 1 }, ResizesIfTheFirstDigitAndZero(new byte[] { 0, 0, 1, 0, 0, 0, 1 }));
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 0, 0, 0 }, ResizesIfTheFirstDigitAndZero(new byte[] { 1, 0, 0, 0, 0, 0, 0 }));
        }
        byte[] ResizesIfTheFirstDigitAndZero(byte[] bytes)
        {
            int counter = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] == 0)
                    counter++;
                else
                    break;
            }
            bytes = RightHandShif(bytes, counter);
            return bytes;
        }

        [TestMethod]
        public void TestIfTheArrayIsGreater()
        {
            Assert.IsTrue(LessThan(ToBinary(1, 2), ToBinary(5, 2)));
            Assert.IsFalse(LessThan(ToBinary(70, 2), ToBinary(6, 2)));
            Assert.IsFalse(LessThan(ToBinary(7, 2), ToBinary(7, 2)));
        }
        bool LessThan(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] bytesEmpty = new byte[0];
            for (int i = Math.Max(bytesOne.Length, bytesTwo.Length) - 1; i >= 0; i--)
            {
                var first = GetDigit(bytesOne, i);
                var second = GetDigit(bytesTwo, i);
                if (first < second)
                    return true;
                if (first > second)
                    return false;
            }
            return false;
        }

        [TestMethod]
        public void TestIfTheArrayIsSmaller()
        {
            Assert.IsTrue(GreaterThan(ToBinary(6, 2), ToBinary(2, 2)));
            Assert.IsFalse(GreaterThan(ToBinary(1, 2), ToBinary(10, 2)));
            Assert.IsFalse(GreaterThan(ToBinary(7, 2), ToBinary(7, 2)));
        }
        bool GreaterThan(byte[] bytesOne, byte[] bytesTwo)
        {
            return LessThan(bytesTwo, bytesOne);
        }


        [TestMethod]
        public void Equal()
        {
            Assert.IsTrue(Equal(ToBinary(9, 2), ToBinary(9, 2)));
            Assert.IsFalse(Equal(ToBinary(9, 2), ToBinary(5, 2)));
        }
        bool Equal(byte[] bytesOne, byte[] bytesTwo)
        {
            return !(NotEqual(bytesOne, bytesTwo));
        }


        [TestMethod]
        public void NotEqual()
        {
            Assert.AreEqual(true, NotEqual(ToBinary(5, 2), ToBinary(7, 2)));
            Assert.AreEqual(false, NotEqual(ToBinary(9, 2), ToBinary(9, 2)));
        }
        bool NotEqual(byte[] bytesOne, byte[] bytesTwo)
        {
            return (LessThan(bytesOne, bytesTwo) || GreaterThan(bytesOne, bytesTwo));
        }

        [TestMethod]
        public void Multiplication()
        {
            CollectionAssert.AreEqual(ToBinary(15, 2), Multiplication(ToBinary(3, 2), ToBinary(5, 2)));
            CollectionAssert.AreEqual(ToBinary(15, 2), Multiplication(ToBinary(5, 2), ToBinary(3, 2)));
            CollectionAssert.AreEqual(ToBinary(8, 2), Multiplication(ToBinary(2, 2), ToBinary(4, 2)));
            CollectionAssert.AreEqual(ToBinary(840, 2), Multiplication(ToBinary(4, 2), ToBinary(210, 2)));
            CollectionAssert.AreEqual(ToBinary(840, 2), Multiplication(ToBinary(210, 2), ToBinary(4, 2)));
            CollectionAssert.AreEqual(ToBinary(3, 2), Multiplication(ToBinary(3, 2), ToBinary(1, 2)));
        }
        byte[] Multiplication(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] result = new byte[Math.Max(bytesTwo.Length, bytesOne.Length)];
            while (!Equal(bytesOne, new byte[] { 0 }))
            {
                result = AddNew(bytesTwo, result);
                bytesOne = Subtraction(bytesOne, new byte[] { 1 });
            }
            result = ResizesIfTheFirstDigitAndZero(result);
            return result;
        }


        [TestMethod]
        public void Division()
        {
            CollectionAssert.AreEqual(new byte[] { 0 }, Division(ToBinary(3, 2), ToBinary(5, 2)));
            CollectionAssert.AreEqual(ToBinary(1, 2), Division(ToBinary(5, 2), ToBinary(3, 2)));
            CollectionAssert.AreEqual(ToBinary(5, 2), Division(ToBinary(15, 2), ToBinary(3, 2)));
            CollectionAssert.AreEqual(ToBinary(500, 2), Division(ToBinary(1500, 2), ToBinary(3, 2)));
            CollectionAssert.AreEqual(ToBinary(1000000, 2), Division(ToBinary(1000000, 2), ToBinary(1, 2)));
        }
        byte[] Division(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] result = new byte[bytesOne.Length];
            if (LessThan(bytesOne, bytesTwo))
                return new byte[] { 0 };
            while (GreaterThan(bytesOne, bytesTwo) || Equal(bytesOne, bytesTwo))
            {
                bytesOne = Subtraction(bytesOne, bytesTwo);
                result = AddNew(result, new byte[] { 1 });
            }
            result = ResizesIfTheFirstDigitAndZero(result);
            return result;
        }


        [TestMethod]
        public void Factorial()
        {
            CollectionAssert.AreEqual(ToBinary(6), Factorial(ToBinary(3,2)));
        }
        byte[] Factorial(byte[] bytes)
        {
            byte[] result = new byte[] { 1 };
            byte[] bytesOne = new byte[] { 0 };
            while (NotEqual(bytes,new byte[] {0}))
            {
                result = Multiplication(result, bytes);
                bytes = Subtraction(bytes, new byte[] {1});
                bytes = ResizesIfTheFirstDigitAndZero(bytes);
            }
            return result;
        }
    }
}