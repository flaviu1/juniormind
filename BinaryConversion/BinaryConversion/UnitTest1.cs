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
            //CollectionAssert.AreEqual(ToBinary(1), And(ToBinary(5), ToBinary(3)));
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
            CollectionAssert.AreEqual(ToBinary(1), RightHandShif(ToBinary(15), 3));
            CollectionAssert.AreEqual(ToBinary(3), RightHandShif(ToBinary(15), 2));
            CollectionAssert.AreEqual(new byte[] {  0, 1 }, RightHandShif(new byte[] { 0,0,0,1 }, 2));
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
            CollectionAssert.AreEqual(ToBinary(10), LefttHandShif(ToBinary(5), 1));
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
            CollectionAssert.AreEqual(ToBinary(6), AddNew(ToBinary(3), ToBinary(3)));
            CollectionAssert.AreEqual(ToBinary(117), AddNew(ToBinary(111), ToBinary(6))); 
            CollectionAssert.AreEqual(ToBinary(6), AddNew(ToBinary(0), ToBinary(6)));
        }
        byte[] AddNew(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] bytesResult = new byte[Math.Max(bytesTwo.Length, bytesOne.Length)];
            int remainder = 0;
            for (int i = 0; i < bytesResult.Length; i++)
            {
                var sum = (GetDigit(bytesOne, i) + GetDigit(bytesTwo, i) + remainder);
                bytesResult[i] = (byte)(sum % 2);
                remainder = sum / 2;
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
            CollectionAssert.AreEqual(ToBinary(12), Subtraction(ToBinary(15), ToBinary(3)));
            CollectionAssert.AreEqual(new byte[] { 1,1,1 }, Subtraction(new byte[] { 0, 0, 1, 1, 1 }, new byte[] { 0, 0, 0, 0, 0 }));
        }
        byte[] Subtraction(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] bytesResult = new byte[Math.Max(bytesTwo.Length, bytesOne.Length)];
            int remainder = 0;
            for (int i = 0; i < bytesResult.Length; i++)
            {
                var decrease = GetDigit(bytesOne, i) - GetDigit(bytesTwo, i) - remainder;
                bytesResult[i] = (byte)((decrease + 2) % 2);
                remainder = (decrease) / 2;
            }
            Array.Reverse(bytesResult);
            bytesResult = CountingZeros(bytesResult);
            return bytesResult;
        }
        [TestMethod]
        public void CounterZero()
        {
            CollectionAssert.AreEqual(new byte[] {1}, CountingZeros(new byte[] { 0, 0, 0,1  }));
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 1 }, CountingZeros(new byte[] { 0, 0, 1, 0, 0, 0, 1 }));
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 0, 0, 0 }, CountingZeros(new byte[] { 1, 0, 0, 0, 0, 0, 0 }));
        }
        byte[] CountingZeros(byte[] bytes )
        {
            int counter = 0;
            for(int i=0;i<bytes.Length;i++)
            {
                if(bytes[i] == 0)
                    counter++;
                else
                break;
            }
           bytes= RightHandShif(bytes, counter);
            return bytes;
        }


        [TestMethod]
        public void TestIfTheArrayIsGreater()
        {
            Assert.IsTrue(LessThan(ToBinary(1),ToBinary(5)));
            Assert.IsFalse(LessThan(ToBinary(70), ToBinary(6))); 
            Assert.IsFalse(LessThan(ToBinary(7), ToBinary(7)));
        }
        bool LessThan(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] bytesEmpty = new byte[0];
            for (int i = Math.Max(bytesOne.Length, bytesTwo.Length)-1;i >=0; i--)
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
            Assert.IsTrue(GreaterThan(ToBinary(6), ToBinary(2)));
            Assert.IsFalse(GreaterThan(ToBinary(1), ToBinary(10)));
            Assert.IsFalse(GreaterThan(ToBinary(7), ToBinary(7)));
        }
        bool GreaterThan(byte[] bytesOne, byte[] bytesTwo)
        {
            return LessThan(bytesTwo,bytesOne);
        }


        [TestMethod]
        public void Equal()
        {
            Assert.IsTrue(Equal(ToBinary(9), ToBinary(9)));
            Assert.IsFalse(Equal(ToBinary(9), ToBinary(5)));
            Assert.IsFalse(Equal(ToBinary(5), ToBinary(53)));
        }
        bool Equal(byte[] bytesOne, byte[] bytesTwo)
        {
            return !(NotEqual(bytesOne, bytesTwo));
        }


        [TestMethod]
        public void NotEqual()
        {
           Assert.AreEqual(true, NotEqual(ToBinary(5), ToBinary(7)));
           Assert.AreEqual(true, NotEqual(ToBinary(7), ToBinary(5)));
           Assert.AreEqual(false, NotEqual(ToBinary(9), ToBinary(9)));
        }
        bool NotEqual(byte[] bytesOne, byte[] bytesTwo)
        {
            return (LessThan(bytesOne, bytesTwo) || GreaterThan(bytesOne, bytesTwo));

        }

        [TestMethod]
        public void Multiplication()
        {
           // CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1}, Multiplication(new byte[] { 0, 1, 0, 1 }, new byte[] { 0, 0, 1, 1 }));
            //CollectionAssert.AreEqual(ToBinary(15), Multiplication(ToBinary(3),ToBinary(5)));
            CollectionAssert.AreEqual(ToBinary(8), Multiplication(ToBinary(2), ToBinary(4)));
        }

        byte[]  Multiplication(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] result =new byte[Math.Max(bytesTwo.Length,bytesOne.Length)];
           // while (!Equal(bytesOne,new byte [0]))
            {
                result = AddNew(bytesTwo, result);
                Subtraction(bytesOne, bytesOne); 
            }
            return result;
        }
       /* byte[] Multiplication(byte[] bytesOne, byte[] bytesTwo)
        {
            byte[] result = new byte[Math.Max(bytesTwo.Length, bytesOne.Length)];
            int n = bytesOne.Length + 1;
            while (n > 0)
            {
                result = AddNew(bytesTwo, result);
                n--;
            }
            return result;
        }*/


        /*[TestMethod]
                public void Division()
                {
                    Assert.AreEqual(5, Division(new byte[] { 1, 0, 1, 0 }, new byte[] { 0, 0, 1,0  }));
                    //CollectionAssert.AreEqual(ToBinary(4), Division(ToBinary(8), ToBinary(2)));
                }

                /*int Division(byte[] bytesOne, byte[] bytesTwo)
                {
                    int n = 0;
                    byte[] counter = GreaterThan(bytesOne, bytesTwo);
                    byte[] bytesThree = {0,0,0,0};
                    while (Equal(counter,bytesThree))
                    {
                        counter = DropNew(counter,ToBinary(2));
                        n++;
                    }
                    return bytesTwo;
                }*/

    }
}