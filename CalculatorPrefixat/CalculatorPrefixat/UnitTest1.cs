using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatesShapedPrefixed
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForAdditionNumber()
        {
            int index = 0;
            Assert.AreEqual(3, Calculate("+ 1 2 ", ref index));
        }
        [TestMethod]
        public void TestForSubtracionNumber()
        {
            int index = 0;
            Assert.AreEqual(-1, Calculate("- 1 2 ", ref index));
        }
        [TestMethod]
        public void TestForMultiplicationNumber()
        {
            int index = 0;
            Assert.AreEqual(2, Calculate("* 1 2 ", ref index));
        }
        [TestMethod]
        public void TestForDivisionNumber()
        {
            int index = 0;
            Assert.AreEqual(2, Calculate("/ 2 1 ", ref index));
        }
        [TestMethod]
        public void ComputerPrefixat()
        {
            int index = 0;
            Assert.AreEqual(1524, 1, Calculate("+ / * + 56 45 46 3 - 1 0.25", ref index));
        }
        double Calculate(string input, ref int index)
        {
            double result = 0;
            string[] counterElement = input.Split(' ');
            string element = counterElement[index++];
            if (double.TryParse(element, out result)) return result;
            return (CheckOperation(element, input, ref index));
        }

        double CheckOperation(string operation, string input, ref int index)
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
