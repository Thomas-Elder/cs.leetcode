using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;

namespace Solutions.Tests.Medium
{
    [TestClass]
    public class ContainerWithMostWaterTests
    {
        private readonly ContainerWithMostWater _containerWithMostWater;

        public ContainerWithMostWaterTests()
        {
            _containerWithMostWater = new ContainerWithMostWater();
        }

        [TestMethod]
        public void ContainerWithMostWater_WhenCalledWithExampleOne_ReturnsExpectedAnswer()
        {
            // Arrange
            var input = new int [] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var expected = 49;

            // Act
            var actual = _containerWithMostWater.MaxArea(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContainerWithMostWater_WhenCalledWithExampleTwo_ReturnsExpectedAnswer()
        {
            // Arrange
            var input = new int[] { 1, 1 };
            var expected = 1;

            // Act
            var actual = _containerWithMostWater.MaxArea(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
