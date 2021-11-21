using System;
using NUnit.Framework;

namespace Lab1.Tests
{
    public class TestForHomeWork3
    {
        [TestCase(10, 10, "+", 20)]
        [TestCase(31, 11, "-", 20)]
        [TestCase(0, 11, "-", -11)]
        [TestCase(77, 3, "*", 231)]
        [TestCase(77, 0, "*", 0)]
        [TestCase(81, 9, "/", 9)]
        public void TestForCalculator(double x, double y, char mathOperation, double temp) => Assert.AreEqual(HomeWorks.HomeWork3.Calculator(x, y, mathOperation), temp,
        "Калькулятор возвращает не верное значение");

        [TestCase(10, 0, "/")]
        [TestCase(77, 3, ")")]
        public void TestForCalculatorNegativ(double x, double y, char mathOperation) => Assert.Throws<Exception>(delegate { HomeWorks.HomeWork3.Calculator(x, y, mathOperation); },
        "Калькулятор не возвращает исключение");
    }
}