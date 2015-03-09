using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Addition()
        {
            var calc = new Calculator.BinaryOperation();

            calc.PreviousTotal = 6;
            calc.StrOperand = "6";

            Assert.AreEqual(12, calc.GetResult());
        }
        [TestMethod]
        public void Multiplication()
        {
            var calc = new Calculator.BinaryOperation()
            {
                PreviousTotal = 8,
                Operator = "x",
                StrOperand = "2.5"
            };

            

            Assert.AreEqual(20, calc.GetResult());
        }
    }
}
