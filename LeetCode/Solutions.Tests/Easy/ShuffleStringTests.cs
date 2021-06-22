using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class ShuffleStringTests
    {
        ShuffleString ShuffleString;

        [TestMethod]
        public void RestoreString_WhenCalledWithLCExample1_ReturnsCorrect()
        {
            // Arrange
            ShuffleString = new ShuffleString();
            string expected = "leetcode";

            string s = "codeleet";
            int[] indicies = { 4, 5, 6, 7, 0, 2, 1, 3 };
            // Act
            string actual = ShuffleString.RestoreString(s, indicies);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RestoreString_WhenCalledWithLCExample2_ReturnsCorrect()
        {
            // Arrange
            ShuffleString = new ShuffleString();
            string expected = "abc";

            string s = "abc";
            int[] indicies = { 0, 1, 2 };
            // Act
            string actual = ShuffleString.RestoreString(s, indicies);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RestoreString_WhenCalledWithLCExample3_ReturnsCorrect()
        {
            // Arrange
            ShuffleString = new ShuffleString();
            string expected = "nihao";

            string s = "aiohn";
            int[] indicies = { 3, 1, 4, 2, 0 };
            // Act
            string actual = ShuffleString.RestoreString(s, indicies);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RestoreString_WhenCalledWithLCExample4_ReturnsCorrect()
        {
            // Arrange
            ShuffleString = new ShuffleString();
            string expected = "arigatou";

            string s = "aaiougrt";
            int[] indicies = { 4, 0, 2, 6, 7, 3, 1, 5 };
            // Act
            string actual = ShuffleString.RestoreString(s, indicies);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RestoreString_WhenCalledWithLCExample5_ReturnsCorrect()
        {
            // Arrange
            ShuffleString = new ShuffleString();
            string expected = "art";

            string s = "rat";
            int[] indicies = { 1, 0, 2 };
            // Act
            string actual = ShuffleString.RestoreString(s, indicies);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
