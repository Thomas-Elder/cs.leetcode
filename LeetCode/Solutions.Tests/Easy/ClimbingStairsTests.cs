using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class ClimbingStairsTests
    {
        private readonly ClimbingStairs _climbingStairs;

        public ClimbingStairsTests()
        {
            _climbingStairs = new ClimbingStairs();
        }

        [TestMethod]
        public void ClimbStairs_WhenPassedZero_ReturnsZero()
        {
            // Arrange
            int input = 0;
            int expected = 0;

            // Act
            var actual = _climbingStairs.ClimbStairs(input);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ClimbStairs_WhenPassedOne_ReturnsOne()
        {
            // Arrange
            int input = 1;
            int expected = 1;

            // Act
            var actual = _climbingStairs.ClimbStairs(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClimbStairs_WhenPassedThree_ReturnsThree()
        {
            // Arrange
            int input = 3;
            int expected = 3;

            // Act
            var actual = _climbingStairs.ClimbStairs(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
