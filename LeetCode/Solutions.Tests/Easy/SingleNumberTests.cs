using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class SingleNumberTests
    {
        private readonly SingleNumber _singleNumber;
        public SingleNumberTests()
        {
            _singleNumber = new SingleNumber();
        }

        [TestMethod]
        public void SingleNumber_WhenPassedExampleOne_ReturnsExpectedResult()
        {
            // Arrange
            var input = new int [] { 2, 2, 1 };
            var expected = 1;

            // Act
            var actual = _singleNumber.GetSingleNumber(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SingleNumber_WhenPassedExampleTwo_ReturnsExpectedResult()
        {
            // Arrange
            var input = new int[] { 4, 1, 2, 1, 2 };
            var expected = 4;

            // Act
            var actual = _singleNumber.GetSingleNumber(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SingleNumber_WhenPassedExampleThree_ReturnsExpectedResult()
        {
            // Arrange
            var input = new int[] { 1 };
            var expected = 1;

            // Act
            var actual = _singleNumber.GetSingleNumber(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
