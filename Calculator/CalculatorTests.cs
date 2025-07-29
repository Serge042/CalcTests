using NUnit.Framework;
using Practices;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        // Тесты для Additional
        [TestCase(5, 10, 15)]
        [TestCase(-3, 7, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, -10, -15)]
        public void Additional_ReturnsCorrectResult(int a, int b, int expected)
        {
            int result = _calculator.Additional(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        // Тесты для Subtraction
        [TestCase(10, 5, 5)]
        [TestCase(3, 8, -5)]
        [TestCase(0, 0, 0)]
        [TestCase(-10, -5, -5)]
        public void Subtraction_ReturnsCorrectResult(int a, int b, int expected)
        {
            int result = _calculator.Subtraction(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        // Тесты для Miltiplication
        [TestCase(5, 10, 50)]
        [TestCase(-3, 7, -21)]
        [TestCase(0, 5, 0)]
        [TestCase(-4, -5, 20)]
        public void Miltiplication_ReturnsCorrectResult(int a, int b, int expected)
        {
            int result = _calculator.Miltiplication(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        // Тесты для Division
        [TestCase(10, 5, 2)]
        [TestCase(7, 3, 2)] // Целочисленное деление
        [TestCase(0, 1, 0)]
        [TestCase(-20, -5, 4)]
        public void Division_ReturnsCorrectResult(int a, int b, int expected)
        {
            int result = _calculator.Division(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Division_ByZero_ThrowsDivideByZeroException()
        {
            int a = 10;
            int b = 0;
            Assert.Throws<DivideByZeroException>(() => _calculator.Division(a, b));
        }
    }
}