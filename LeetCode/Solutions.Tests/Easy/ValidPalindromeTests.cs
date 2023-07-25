using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class ValidPalindromeTests
    {
        private readonly ValidPalindrome _validPalindrome;

        public ValidPalindromeTests()
        {
            _validPalindrome = new ValidPalindrome();
        }

        [TestMethod]
        public void IsPalindrome_WhenCalledWithExampleOne_ReturnsExpectedResult()
        {
            // Arrange
            var input = "A man, a plan, a canal: Panama";
            var expected = true;

            // Act
            var actual = _validPalindrome.IsPalindrome(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPalindrome_WhenCalledWithExampleTwo_ReturnsExpectedResult()
        {
            // Arrange
            var input = "race a car";
            var expected = false;

            // Act
            var actual = _validPalindrome.IsPalindrome(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPalindrome_WhenCalledWithExampleThree_ReturnsExpectedResult()
        {
            // Arrange
            var input = " ";
            var expected = true;

            // Act
            var actual = _validPalindrome.IsPalindrome(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
