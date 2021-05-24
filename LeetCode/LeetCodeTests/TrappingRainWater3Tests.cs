using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace Problems.Tests
{
    [TestClass]
    public class TrappingRainWater3Tests
    {
        TrappingRainWater3 rainGauge = new TrappingRainWater3();

        [TestMethod]
        public void Rainfall_WithFlatTerrainAllZeros_ReturnsZero()
        {
            // Arrange
            int[] terrain = { 0, 0, 0, 0 };
            int expected = 0;

            // Act
            int actual = rainGauge.Trap(terrain);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Rainfall_WithFlatTerrain_ReturnsZero()
        {
            // Arrange
            int[] terrain = { 3, 3, 3, 3 };
            int expected = 0;

            // Act
            int actual = rainGauge.Trap(terrain);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Rainfall_WithTerrain_ReturnsOne()
        {
            // Arrange
            int[] terrain = { 0, 1, 0, 1 };
            int expected = 1;

            // Act
            int actual = rainGauge.Trap(terrain);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Rainfall_WithAsymmetricalTerrainRight_ReturnsVolumeBasedOnShortWall()
        {
            // Arrange
            int[] terrain = { 0, 1, 0, 2 };
            int expected = 1;

            // Act
            int actual = rainGauge.Trap(terrain);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Rainfall_WithAsymmetricalTerrainLeft_ReturnsVolumeBasedOnShortWall()
        {
            // Arrange
            int[] terrain = { 0, 2, 0, 1 };
            int expected = 1;

            // Act
            int actual = rainGauge.Trap(terrain);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Rainfall_WithMultipleLocalMinimums_ReturnsSumOfMultipleLakes()
        {
            // Arrange
            int[] terrain = { 0, 1, 0, 1, 0, 1, 0 };
            int expected = 2;

            // Act
            int actual = rainGauge.Trap(terrain);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Rainfall_WithMultipleLocalMinimumsPartOfLargerLocalMinimums_ReturnsFive()
        {
            // Arrange
            int[] terrain = { 0, 2, 0, 1, 0, 2, 0 };
            int expected = 5;

            // Act
            int actual = rainGauge.Trap(terrain);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Rainfall_WithFlatBottomLake_ReturnsFullVolume()
        {
            // Arrange
            int[] terrain = { 0, 2, 0, 0, 0, 2, 0 };
            int expected = 6;

            // Act
            int actual = rainGauge.Trap(terrain);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Rainfall_WithComplicatedTerrain_ReturnsSix()
        {
            // Arrange
            int[] terrain = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int expected = 6;

            // Act
            int actual = rainGauge.Trap(terrain);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Rainfall_WithLargeLCExample_ReturnsZero()
        {
            // Arrange
            int[] terrain = new int [981];

            int i;
            int j = 0;

            for (i = 980; i >= 0; i--)
                terrain[j++] = i;

            int expected = 0;

            // Act
            int actual = rainGauge.Trap(terrain);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LandToTheLeft_WithOneHeightWalls_ReturnsTrue()
        {
            // Arrange
            int[] height = {1, 0, 1};
            bool expected = true;

            // Act
            bool actual = rainGauge.LandToTheLeft(height, 0, 1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LandToTheLeft_WithNoWalls_ReturnsFalse()
        {
            // Arrange
            int[] height = { 0, 0, 0 };
            bool expected = false;

            // Act
            bool actual = rainGauge.LandToTheLeft(height, 0, 1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LandToTheRight_WithNoWalls_ReturnsFalse()
        {
            // Arrange
            int[] height = { 0, 0, 0 };
            bool expected = false;

            // Act
            bool actual = rainGauge.LandToTheRight(height, 0, 1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LandToTheLeft_WithOnlyOneWall_ReturnsFalse()
        {
            // Arrange
            int[] height = { 0, 0, 1 };
            bool expected = false;

            // Act
            bool actual = rainGauge.LandToTheLeft(height, 0, 1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LandToTheRight_WithOnlyOneWall_ReturnsFalse()
        {
            // Arrange
            int[] height = { 1, 0, 0 };
            bool expected = false;

            // Act
            bool actual = rainGauge.LandToTheRight(height, 0, 1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LandToTheLeft_WithCoordOfLandAndNoOtherLandToLeft_ReturnsFalse()
        {
            // Arrange
            int[] height = { 0, 0, 1 };
            bool expected = false;

            // Act
            bool actual = rainGauge.LandToTheLeft(height, 1, 2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LandToTheRight_WithCoordOfLandAndNoOtherLandToRight_ReturnsFalse()
        {
            // Arrange
            int[] height = { 1, 0, 0 };
            bool expected = false;

            // Act
            bool actual = rainGauge.LandToTheLeft(height, 1, 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
