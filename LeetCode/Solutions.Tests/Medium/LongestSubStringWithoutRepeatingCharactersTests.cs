using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;

namespace Solutions.Tests.Medium
{
    [TestClass]
    public class LongestSubStringWithoutRepeatingCharactersTests
    {
        private readonly LongestSubStringWithoutRepeatingCharacters _sut;

        public LongestSubStringWithoutRepeatingCharactersTests()
        {
            _sut = new LongestSubStringWithoutRepeatingCharacters();
        }

        [TestMethod]
        public void LengthOfLongestSubstring_WhenGivenExampleOne_ReturnsCorrectResult()
        {
            // Arrange
            string input = "abcabcbb";
            int expected = 3;

            // Act 
            var result = _sut.LengthOfLongestSubstring(input);

            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_WhenGivenExampleTwo_ReturnsCorrectResult()
        {
            // Arrange
            string input = "bbbbb";
            int expected = 1;

            // Act 
            var result = _sut.LengthOfLongestSubstring(input);

            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_WhenGivenExampleThree_ReturnsCorrectResult()
        {
            // Arrange
            string input = "pwwkew";
            int expected = 3;

            // Act 
            var result = _sut.LengthOfLongestSubstring(input);

            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_WhenGivenExampleFour_ReturnsCorrectResult()
        {
            // Arrange
            string input = " ";
            int expected = 1;

            // Act 
            var result = _sut.LengthOfLongestSubstring(input);

            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_WhenGivenAnEmptyString_ReturnsZero()
        {
            // Arrange
            string input = "";
            int expected = 0;

            // Act 
            var result = _sut.LengthOfLongestSubstring(input);

            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_WhenGivenExampleFive_ReturnsCorrectResult()
        {
            // Arrange
            string input = "au";
            int expected = 2;

            // Act 
            var result = _sut.LengthOfLongestSubstring(input);

            // Assert 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LengthOfLongestSubstring_WhenGivenExampleSix_ReturnsCorrectResult()
        {
            // Arrange
            string input = "dvdf";
            int expected = 3;

            // Act 
            var result = _sut.LengthOfLongestSubstring(input);

            // Assert 
            Assert.AreEqual(expected, result);
        }
    }
}
