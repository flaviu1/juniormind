using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pascal_sTriangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = new int[] { 1, 4, 6, 4, 1 };
            CollectionAssert.AreEqual(result, CalculateTrianglHisPascal(5));
            var result1 = new int[] { 1, 9, 36, 84, 126, 126, 84, 36, 9, 1};
            CollectionAssert.AreEqual(result1, CalculateTrianglHisPascal(10));
        }

        [TestMethod]
        public void TestCalculateTrianglePascalRecursive()
        {
            var result = new int[] { 1, 4, 6, 4, 1 };
            CollectionAssert.AreEqual(result, CalculateTrianglHisPascal(5));
            var result1 = new int[] { 1, 9, 36, 84, 126, 126, 84, 36, 9, 1 };
            CollectionAssert.AreEqual(result1, CalculateTrianglHisPascal(10));
        }
        int[] CalculateTrianglHisPascalRecursive(int number)
        {
            if (number == 1) return new int[] { 1 };
            int[] result = new int[number];
            result[0] = 1;
            result[number - 1] = 1;

            int[] previousLine = CalculateTrianglHisPascalRecursive(number - 1);

            result=CreatesNewLine(number, previousLine);
            return result;
        }

        private static int[] CreatesNewLine(int number, int[] previousLine)
        {
            int[] result = new int[number];
            for (int i = 1; i < number - 1; i++)
            {
                result[i] = previousLine[i - 1] + previousLine[i];
            }
            return result;
        }


        int[] CalculateTrianglHisPascal(int number)
        {
            int[] first = new int[] { 1 };
            int[] second = new int[] { 1, 1 };
            int counter = 0;
            while (counter < number)
            {
                first = new int[second.Length + 1];
                for (int i = 1; i <= second.Length - 1; i++)
                {
                    first[0] = 1;
                    first[i] = second[i - 1] + second[i];
                    first[second.Length] = 1;
                }
                second = first;
                counter = second.Length;
            }
            return second;
        }
    }
}
