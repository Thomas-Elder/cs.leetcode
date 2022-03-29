using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class PalindromeNumberTests
    {

        private readonly PalindromeNumber _palindromeNumber;

        public PalindromeNumberTests()
        {
            _palindromeNumber = new PalindromeNumber();
        }

        [TestMethod]
        public void IsPalindrome_WhenGiven121_ReturnsTrue()
        {
            // Arrange
            int input = 121;

            // Act
            bool result = _palindromeNumber.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_WhenGivenNegative121_ReturnsFalse()
        {
            // Arrange
            int input = -121;

            // Act
            bool result = _palindromeNumber.IsPalindrome(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindrome_WhenGiven10_ReturnsFalse()
        {
            // Arrange
            int input = 10;

            // Act
            bool result = _palindromeNumber.IsPalindrome(input);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
