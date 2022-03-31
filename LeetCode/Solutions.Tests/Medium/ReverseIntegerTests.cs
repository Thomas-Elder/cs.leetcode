using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;

namespace Solutions.Tests.Medium
{
    [TestClass]
    public class ReverseIntegerTests
    {
        private readonly ReverseInteger _reverseInteger;

        public ReverseIntegerTests()
        {
            _reverseInteger = new ReverseInteger();
        }

        [TestMethod]
        public void Reverse_WhenCalledWithExample1_ReturnsCorrectResult()
        {
            // Arrange
            var input = 123;
            var expected = 321;

            // Act
            var result = _reverseInteger.Reverse(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Reverse_WhenCalledWithExample2_ReturnsCorrectResult()
        {
            // Arrange
            var input = -123;
            var expected = -321;

            // Act
            var result = _reverseInteger.Reverse(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Reverse_WhenCalledWithExample3_ReturnsCorrectResult()
        {
            // Arrange
            var input = 120;
            var expected = 21;

            // Act
            var result = _reverseInteger.Reverse(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
