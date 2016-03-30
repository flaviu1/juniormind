using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForAdditionNumber()
        {
            Assert.AreEqual(3, Calculate("+ 1 2 "));
        }
        [TestMethod]
        public void TestForSubtracionNumber()
        {
            Assert.AreEqual(-1, Calculate("- 1 2 "));
        }
        [TestMethod]
        public void TestForMultiplicationNumber()
        {
            Assert.AreEqual(2, Calculate("* 1 2 "));
        }
        [TestMethod]
        public void TestForDivisionNumber()
        {
            Assert.AreEqual(2, Calculate("/ 2 1 "));
        }
        [TestMethod]
        public void ComputerPrefixat()
        {
            Assert.AreEqual(1524, 1, Calculate("+ / * + 56 45 46 3 - 1 0.25"));
        }

        double Calculate(string[] input, ref int index)
        {
            double result = 0;
            string element = input[index++];
            if (double.TryParse(element, out result)) return result;
            return (CheckOperation(element, input, ref index));
        }

        double Calculate(string input)
        {
            string[] counterElement = input.Split(' ');
            int index = 0;
            return Calculate( counterElement, ref index);
        }

        double CheckOperation(string operation, string[] input, ref int index)
        {
            switch (operation)
            {
                case "+": return Calculate(input, ref index) + Calculate(input, ref index);
                case "-": return Calculate(input, ref index) - Calculate(input, ref index);
                case "*": return Calculate(input, ref index) * Calculate(input, ref index);
            }
            return Calculate(input, ref index) / Calculate(input, ref index);
        }
    }
}
