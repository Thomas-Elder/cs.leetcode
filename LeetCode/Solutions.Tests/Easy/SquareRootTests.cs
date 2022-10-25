using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class SquareRootTests
    {
        private readonly SquareRoot _squareRoot;

        public SquareRootTests()
        {
            _squareRoot = new SquareRoot();
        }

        [TestMethod]
        public void MySqrt_WhenPassedZero_ReturnsZero()
        {
            // Arrange
            int input = 0;
            int expected = 0;

            // Act
            var actual = _squareRoot.MySqrt(input);

            // Assert 
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void MySqrt_WhenPassedSquareNumber_ReturnsSquareRoot()
        {
            // Arrange
            int input = 4;
            int expected = 2;

            // Act
            var actual = _squareRoot.MySqrt(input);

            // Assert 
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void MySqrt_WhenPassedNonSquareNumber_ReturnsRoundedDownSquareRoot()
        {
            // Arrange
            int input = 8;
            int expected = 2;

            // Act
            var actual = _squareRoot.MySqrt(input);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MySqrt_WhenPassedALargeNumber_ReturnsSquareRoot()
        {
            // Arrange
            int input = 2147395599;
            int expected = 46339;

            // Act
            var actual = _squareRoot.MySqrt(input);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
