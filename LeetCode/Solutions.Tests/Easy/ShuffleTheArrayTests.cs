using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class ShuffleTheArrayTests
    {
        ShuffleTheArray ShuffleTheArray;

        [TestMethod]
        public void Shuffle_WhenCalledWithLCExample1_ReturnsTheCorrectResult()
        {
            // Arrange
            ShuffleTheArray ShuffleTheArray = new ShuffleTheArray();
            int[] nums = { 2, 5, 1, 3, 4, 7 };
            int n = 3;
            int[] expected = {2, 3, 5, 4, 1, 7};

            // Act 
            int[] actual = ShuffleTheArray.Shuffle(nums, n);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Shuffle_WhenCalledWithLCExample2_ReturnsTheCorrectResult()
        {
            // Arrange
            ShuffleTheArray ShuffleTheArray = new ShuffleTheArray();
            int[] nums = { 1, 2, 3, 4, 4, 3, 2, 1 };
            int n = 4;
            int[] expected = { 1, 4, 2, 3, 3, 2, 4, 1 };

            // Act 
            int[] actual = ShuffleTheArray.Shuffle(nums, n);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Shuffle_WhenCalledWithLCExample3_ReturnsTheCorrectResult()
        {
            // Arrange
            ShuffleTheArray ShuffleTheArray = new ShuffleTheArray();
            int[] nums = { 1, 1, 2, 2 };
            int n = 2;
            int[] expected = { 1, 2, 1, 2 };

            // Act 
            int[] actual = ShuffleTheArray.Shuffle(nums, n);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
