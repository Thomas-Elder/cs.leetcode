using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;
using Utility;

namespace Solutions.Tests.Medium
{
    [TestClass]
    public class DivideTwoIntegersTests
    {
        private readonly DivideTwoIntegers _sut;

        public DivideTwoIntegersTests()
        {
            _sut = new DivideTwoIntegers();
        }

        [TestMethod]
        public void Divide_WhenCalledWithExample1_ReturnsGivenResult()
        {
            // Arrange
            int dividend = 10;
            int divisor = 3;
            int expected = 3;

            // Act 
            var result = _sut.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_WhenCalledWithExample2_ReturnsGivenResult()
        {
            // Arrange
            int dividend = 7;
            int divisor = -3;
            int expected = -2;

            // Act 
            var result = _sut.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_WhenCalledWithExample3_ReturnsGivenResult()
        {
            // Arrange
            int dividend = 1;
            int divisor = 1;
            int expected = 1;

            // Act 
            var result = _sut.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_WhenCalledWithExample4_ReturnsGivenResult()
        {
            // Arrange
            int dividend = -2147483648;
            int divisor = -1;
            int expected = 2147483647;

            // Act 
            var result = _sut.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expected, result);
        }


        public void Divide_RoundTwo_WhenCalledWithExample1_ReturnsGivenResult()
        {
            // Arrange
            int dividend = 10;
            int divisor = 3;
            int expected = 3;

            // Act 
            var result = _sut.Divide_RoundTwo(dividend, divisor);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_RoundTwo_WhenCalledWithExample2_ReturnsGivenResult()
        {
            // Arrange
            int dividend = 7;
            int divisor = -3;
            int expected = -2;

            // Act 
            var result = _sut.Divide_RoundTwo(dividend, divisor);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_RoundTwo_WhenCalledWithExample3_ReturnsGivenResult()
        {
            // Arrange
            int dividend = 1;
            int divisor = 1;
            int expected = 1;

            // Act 
            var result = _sut.Divide_RoundTwo(dividend, divisor);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_RoundTwo_WhenCalledWithExample4_ReturnsGivenResult()
        {
            // Arrange
            int dividend = -2147483648;
            int divisor = -1;
            int expected = 2147483647;

            // Act 
            var result = _sut.Divide_RoundTwo(dividend, divisor);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
