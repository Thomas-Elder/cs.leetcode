using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class LengthOfLastWordTests
    {
        private readonly LengthOfLastWord _lengthOfLastWord;

        public LengthOfLastWordTests()
        {
            _lengthOfLastWord = new LengthOfLastWord();
        }

        [TestMethod]
        public void LengthOfLastWordMethod_WhenPassedHelloWorld_Returns5()
        {
            // Arrange
            string input = "Hello World";
            int expected = 5;

            // Act
            int actual = _lengthOfLastWord.LengthOfLastWordMethod(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LengthOfLastWordMethod_WhenPassedAStringEndingInSpace_ReturnsCorrectLength()
        {
            // Arrange
            string input = "Hello World ";
            int expected = 5;

            // Act
            int actual = _lengthOfLastWord.LengthOfLastWordMethod(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LengthOfLastWordMethod_WhenPassedAStringEndingInSpaces_ReturnsCorrectLength()
        {
            // Arrange
            string input = "Hello World     ";
            int expected = 5;

            // Act
            int actual = _lengthOfLastWord.LengthOfLastWordMethod(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LengthOfLastWordMethod_WhenPassedAStringWithMoreThanTwoWords_ReturnsCorrectLength()
        {
            // Arrange
            string input = "Hello is still worlds";
            int expected = 6;

            // Act
            int actual = _lengthOfLastWord.LengthOfLastWordMethod(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
