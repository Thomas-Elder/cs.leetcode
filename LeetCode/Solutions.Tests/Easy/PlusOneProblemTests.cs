using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class PlusOneProblemTests
    {
        private PlusOneProblem _plusOneProblem;

        public PlusOneProblemTests()
        {
            _plusOneProblem = new PlusOneProblem();
        }

        [TestMethod]
        public void PlusOne_WhenASingleDigitLessThan9_ReturnsSingleDigit1Higher()
        {
            // Arrange
            int[] input = { 1 };
            int[] expected = { 2 };

            // Act
            var actual = _plusOneProblem.PlusOne(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOne_WhenThreeDigitsLastDigitLessThan9_ReturnsIncrementedInteger()
        {
            // Arrange
            int[] input = { 1, 2, 3 };
            int[] expected = { 1, 2, 4 };

            // Act
            var actual = _plusOneProblem.PlusOne(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOne_WhenThreeDigitsLastDigitIs9_ReturnsIncrementedInteger()
        {
            // Arrange
            int[] input = { 1, 2, 9 };
            int[] expected = { 1, 3, 0 };

            // Act
            var actual = _plusOneProblem.PlusOne(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOne_WhenThreeDigitsAllDigits9_ReturnsArray1Longer()
        {
            // Arrange
            int[] input = { 9, 9, 9 };
            int[] expected = { 1, 0, 0, 0 };

            // Act
            var actual = _plusOneProblem.PlusOne(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOne_WhenThreeDigitsSecondDigit9_ReturnsIncrementedArraySameLength()
        {
            // Arrange
            int[] input = { 9, 9, 0 };
            int[] expected = { 9, 9, 1 };

            // Act
            var actual = _plusOneProblem.PlusOne(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOne_WhenFailingLeetCodeTest_ReturnsExpectedAnswer()
        {
            // Arrange
            int[] input = { 8, 9, 9, 9 };
            int[] expected = { 9, 0, 0, 0 };

            // Act
            var actual = _plusOneProblem.PlusOne(input);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
