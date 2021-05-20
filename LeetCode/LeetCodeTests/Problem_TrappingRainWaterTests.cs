using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCodeTests
{
    [TestClass]
    public class Problem_TrappingRainWaterTests
    {
        Problem_TrappingRainWater rainGauge = new Problem_TrappingRainWater();

        [TestMethod]
        public void Rainfall_WithFlatTerrainAllZeros_ReturnsZero()
        {
            // Arrange
            int[] terrain = { 0, 0, 0, 0 };
            int expected = 0;

            // Act
            int actual = rainGauge.Rainfall(terrain);

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
            int actual = rainGauge.Rainfall(terrain);

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
            int actual = rainGauge.Rainfall(terrain);

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
            int actual = rainGauge.Rainfall(terrain);

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
            int actual = rainGauge.Rainfall(terrain);

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
            int actual = rainGauge.Rainfall(terrain);

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
            int actual = rainGauge.Rainfall(terrain);

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
            int actual = rainGauge.Rainfall(terrain);

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
            int actual = rainGauge.Rainfall(terrain);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LandToTheLeft_WithOneHeightWalls_ReturnsOne()
        {
            // Arrange
            bool[,] map = new bool[,] { {false,false,false }, {true,false,true }, {true,true,true } };
            bool expected = true;

            // Act
            bool actual = rainGauge.LandToTheLeft(map, 1, 1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LandToTheLeft_WithNoWalls_ReturnsFalse()
        {
            // Arrange
            bool[,] map = new bool[,] { { false, false, false }, { false, false, false }, { true, true, true } };
            bool expected = false;

            // Act
            bool actual = rainGauge.LandToTheLeft(map, 1, 1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LandToTheRight_WithNoWalls_ReturnsFalse()
        {
            // Arrange
            bool[,] map = new bool[,] { { false, false, false }, { false, false, false }, { true, true, true } };
            bool expected = false;

            // Act
            bool actual = rainGauge.LandToTheRight(map, 1, 1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LandToTheLeft_WithOnlyOneWall_ReturnsFalse()
        {
            // Arrange
            bool[,] map = new bool[,] { { false, false, false }, { false, false, true }, { true, true, true } };
            bool expected = false;

            // Act
            bool actual = rainGauge.LandToTheLeft(map, 1, 1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LandToTheRight_WithOnlyOneWall_ReturnsFalse()
        {
            // Arrange
            bool[,] map = new bool[,] { { false, false, false }, { true, false, false }, { true, true, true } };
            bool expected = false;

            // Act
            bool actual = rainGauge.LandToTheRight(map, 1, 1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LandToTheLeft_WithCoordOfLandAndNoOtherLandToLeft_ReturnsFalse()
        {
            // Arrange
            bool[,] map = new bool[,] { { false, false, false }, { false, false, true }, { true, true, true } };
            bool expected = false;

            // Act
            bool actual = rainGauge.LandToTheLeft(map, 1, 2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LandToTheRight_WithCoordOfLandAndNoOtherLandToRight_ReturnsFalse()
        {
            // Arrange
            bool[,] map = new bool[,] { { false, false, false }, { true, false, false }, { true, true, true } };
            bool expected = false;

            // Act
            bool actual = rainGauge.LandToTheLeft(map, 1, 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
