using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;
using System.ComponentModel.DataAnnotations;
using Utility;

namespace Solutions.Tests.Medium
{
    [TestClass]
    public class LargestPalindromicSubStringTests
    {
        private readonly LargestPalindromicSubString _largestPalindromicSubstring;

        public LargestPalindromicSubStringTests()
        {
            _largestPalindromicSubstring = new LargestPalindromicSubString();
        }

        [TestMethod]
        public void LongestPalindrome_WhenPassedExampleOne_ReturnsExpectedOutput()
        {
            // Arrange
            var input = "babad";
            var expected = "aba";

            // Act
            var actual = _largestPalindromicSubstring.LongestPalindrome(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestPalindrome_WhenPassedExampleTwo_ReturnsExpectedOutput()
        {
            // Arrange
            var input = "cbbd";
            var expected = "bb";

            // Act
            var actual = _largestPalindromicSubstring.LongestPalindrome(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
