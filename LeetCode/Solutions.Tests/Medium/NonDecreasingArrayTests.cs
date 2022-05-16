using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;
using Utility;

namespace Solutions.Tests.Medium
{
    [TestClass]
    public  class NonDecreasingArrayTests
    {
        private readonly NonDecreasingArray _sut;

        public NonDecreasingArrayTests()
        {
            _sut = new NonDecreasingArray();
        }

        [TestMethod]
        public void CheckPossibility_WhenCalledWithExample1_ReturnsTrue()
        {
            // Arrange
            var input = new int [] { 4, 2, 3 };

            // Act
            var result = _sut.CheckPossibility(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckPossibility_WhenCalledWithExample2_ReturnsFalse()
        {
            // Arrange
            var input = new int[] { 4, 2, 1 };

            // Act
            var result = _sut.CheckPossibility(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckPossibility_WhenCalledWithExample3_ReturnsFalse()
        {
            // Arrange
            var input = new int[] { 3, 4, 2, 3 };

            // Act
            var result = _sut.CheckPossibility(input);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
