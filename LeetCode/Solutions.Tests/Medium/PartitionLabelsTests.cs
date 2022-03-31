using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;
using System.Collections.Generic;

namespace Solutions.Tests.Medium
{
    [TestClass]
    public class PartitionLabelsTests
    {

        [TestMethod]
        public void PartitionLabels_WhenPassedStringOfSameFourChars_ReturnsListWithExpectedValue()
        {
            // Arrange
            PartitionLabels partitionLabels = new PartitionLabels();
            List<int> expected = new List<int>(4);
            expected.Add(4);
            string s = "aaaa";

            // Act
            List<int> actual = partitionLabels.Partition(s);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PartitionLabels_WhenPassedStringOfDifferentFourChars_ReturnsListWithOneElement()
        {
            // Arrange
            PartitionLabels partitionLabels = new PartitionLabels();
            List<int> expected = new List<int>(1);
            expected.Add(1);
            expected.Add(1);
            expected.Add(1);
            expected.Add(1);
            string s = "abcd";

            // Act
            List<int> actual = partitionLabels.Partition(s);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void PartitionLabels_WhenPassedStringFromTCExample_ReturnsListWithCorrectLength()
        {
            // Arrange
            PartitionLabels partitionLabels = new PartitionLabels();
            List<int> expected = new List<int>(500);
            expected.Add(9);
            expected.Add(7);
            expected.Add(8);
            string s = "ababcbacadefegdehijhklij";

            // Act
            List<int> actual = partitionLabels.Partition(s);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void PartitionLabels_WhenPassedStringFromTCExample_ReturnsListWithCorrectValues()
        {
            // Arrange
            PartitionLabels partitionLabels = new PartitionLabels();
            List<int> expected = new List<int>(500);
            expected.Add(9);
            expected.Add(7);
            expected.Add(8);
            string s = "ababcbacadefegdehijhklij";

            // Act
            List<int> actual = partitionLabels.Partition(s);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PartitionLabels_WhenPassedStringFromLCExample2_ReturnsListWithCorrectValues()
        {
            // Arrange
            PartitionLabels partitionLabels = new PartitionLabels();
            List<int> expected = new List<int>(500);
            expected.Add(1);
            expected.Add(9);
            string s = "caedbdedda";

            // Act
            List<int> actual = partitionLabels.Partition(s);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PartitionLabels_WhenPassedStringFromLCExample3_ReturnsListWithCorrectValues()
        {
            // Arrange
            PartitionLabels partitionLabels = new PartitionLabels();
            List<int> expected = new List<int>(500);
            expected.Add(13);
            expected.Add(1);
            expected.Add(1);
            string s = "qiejxqfnqceocmy";

            // Act
            List<int> actual = partitionLabels.Partition(s);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
