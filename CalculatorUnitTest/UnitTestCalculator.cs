using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CalculatorTest;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTestCalculator
    {
        [TestMethod]
        public void TestMethod_Sum()
        {
            double a = 5;
            double b = 10;

            var expected = a + b;
            var actual = Program.Sum(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_Division()
        {
            double a = 5;
            double b = 10;

            var expected = a / b;
            var actual = Program.Division(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_Multiplication()
        {
            double a = 5;
            double b = 10;

            var expected = a * b;
            var actual = Program.Multiplication(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_Subtraction()
        {
            double a = 5.5;
            double b = 6.3;

            var expected = a - b;
            var actual = Program.Subtraction(5.5, 6.2);

            Assert.AreEqual(expected, actual, 0.1, "Погрешность привышает 0,1");
        }

        [TestMethod]
        public void TestMethod_Subtraction2()
        {
            double a = 5;
            double b = 10;

            var expected = a - b;
            var actual = Program.Subtraction(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroExceprion()
        {
            double a = 5;
            double b = 0;

            var expected = a / b;
            var actual = Program.Division(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
