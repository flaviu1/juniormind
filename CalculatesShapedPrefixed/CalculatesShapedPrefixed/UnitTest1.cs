using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatesShapedPrefixed
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0,Calculate("+ - 1 2 3"));
        }

        int Calculate(string operation)
        {
            int counter=0;
            int result=0;
            counter += CountOperation(operation);
            for (int i = 0; i < operation.Length;i++)
            {
                if (operation[i] == '+')
                {
                    result += (int)operation[counter] + (int)operation[counter + 1];
                    counter += 2;
                }
                if (operation[i] == '-')
                {
                    result += operation[counter] - operation[counter + 1];
                    counter += 2;
                } if (operation[i] == '*')
                {
                    result += operation[counter] * operation[counter + 1];
                    counter += 2;
                } if (operation[i] == '/')
                {
                    result += operation[counter] / operation[counter + 1];
                    counter += 2;
                }
            }
                return result;
        }

        private static int CountOperation(string operation)
        {
            int counter = 0;
            for (int i = 0; i < operation.Length; i++)
            {
                if ((operation[i] == '+') && (operation[i] != 0)) counter++;
                if ((operation[i] == '-') && (operation[i] != 0)) counter++;
                if ((operation[i] == '*') && (operation[i] != 0)) counter++;
                if ((operation[i] == '/') && (operation[i] != 0)) counter++;
            }
            return counter;
        }
    }
}
