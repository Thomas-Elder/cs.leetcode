using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;

namespace Solutions.Tests.Medium
{
    [TestClass]
    public class ATOITests
    {
        private readonly ATOI _atoi;
        public ATOITests() 
        { 
            _atoi = new ATOI();
        }

        [TestMethod]
        public void MyAtoi_WhenGivenExampleOne_ReturnsExpectedResult()
        {
            // Arrange
            string input = "42";
            int expected = 42;

            // Act
            var actual = _atoi.MyAtoi(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyAtoi_WhenGivenExampleTwo_ReturnsExpectedResult()
        {
            // Arrange
            string input = "-42";
            int expected = -42;

            // Act
            var actual = _atoi.MyAtoi(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyAtoi_WhenGivenExampleThree_ReturnsExpectedResult()
        {
            // Arrange
            string input = "4193 with words";
            int expected = 4193;

            // Act
            var actual = _atoi.MyAtoi(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
