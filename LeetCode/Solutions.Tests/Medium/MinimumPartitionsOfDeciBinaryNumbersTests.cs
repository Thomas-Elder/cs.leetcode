using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;

namespace Solutions.Tests.Medium
{
    [TestClass]
    public class MinimumPartitionsOfDeciBinaryNumbersTests
    {
        private readonly MinimumPartitionsOfDeciBinaryNumbers _minimumPartitionsOfDeciBinaryNumbers;

        public MinimumPartitionsOfDeciBinaryNumbersTests()
        {
            _minimumPartitionsOfDeciBinaryNumbers = new MinimumPartitionsOfDeciBinaryNumbers();
        }

        [TestMethod]
        public void MinPartitions_WhenPassedEmptyString_ReturnsZero()
        {
            // Arrange
            string input = "";
            int expected = 0;

            // Act
            int actual = _minimumPartitionsOfDeciBinaryNumbers.MinPartitions(input);

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinPartitions_WhenPassedOne_ReturnsOne()
        {
            // Arrange
            string input = "1";
            int expected = 1;

            // Act
            int actual = _minimumPartitionsOfDeciBinaryNumbers.MinPartitions(input);

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinPartitions_WhenPassed2_Returns2()
        {
            // Arrange
            string input = "2";
            int expected = 2;

            // Act
            int actual = _minimumPartitionsOfDeciBinaryNumbers.MinPartitions(input);

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinPartitions_WhenPassedExampleOne_ReturnsExpectedResult()
        {
            // Arrange
            string input = "32";
            int expected = 3;

            // Act
            int actual = _minimumPartitionsOfDeciBinaryNumbers.MinPartitions(input);

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinPartitions_WhenPassedExampleTwo_ReturnsExpectedResult()
        {
            // Arrange
            string input = "82734";
            int expected = 8;

            // Act
            int actual = _minimumPartitionsOfDeciBinaryNumbers.MinPartitions(input);

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinPartitions_WhenPassedExampleThree_ReturnsExpectedResult()
        {
            // Arrange
            string input = "27346209830709182346";
            int expected = 9;

            // Act
            int actual = _minimumPartitionsOfDeciBinaryNumbers.MinPartitions(input);

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }
    }
}
