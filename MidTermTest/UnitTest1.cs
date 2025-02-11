using NUnit.Framework;
using MidTerm;
using System;

namespace MidTermTest
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new SimpleCalculator();
        }

        // Addition Tests
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            double a = 5, b = 3;
            double expected = 8;

            // Act
            double actual = _calculator.Add(a, b);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            // Arrange
            double a = 5, b = -3;
            double expected = 2;

            // Act
            double actual = _calculator.Add(a, b);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Subtraction Tests
        [Test]
        public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            double a = 10, b = 4;
            double expected = 6;

            // Act
            double actual = _calculator.Subtract(a, b);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Subtract_PositiveAndNegativeNumber_ReturnsCorrectDifference()
        {
            // Arrange
            double a = 5, b = -3;
            double expected = 8;

            // Act
            double actual = _calculator.Subtract(a, b);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Multiplication Tests
        [Test]
        public void Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            double a = 5, b = 3;
            double expected = 15;

            // Act
            double actual = _calculator.Multiply(a, b);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Multiply_NumberWithZero_ReturnsZero()
        {
            // Arrange
            double a = 5, b = 0;
            double expected = 0;

            // Act
            double actual = _calculator.Multiply(a, b);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Division Tests
        [Test]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            double a = 10, b = 2;
            double expected = 5;

            // Act
            double actual = _calculator.Divide(a, b);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            double a = 10, b = 0;

            // Act & Assert
            Assert.That(() => _calculator.Divide(a, b), Throws.TypeOf<DivideByZeroException>());
        }
    }
}
