using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System.Collections.Generic;

namespace LeetCodeTests
{
    [TestClass]
    public class Problem_PartitionLabelsTests
    {

        [TestMethod]
        public void PartitionLabels_WhenPassedStringOfSameFourChars_ReturnsListWithExpectedValue()
        {
            // Arrange
            Problem_PartitionLabels problem_PartitionLabels = new Problem_PartitionLabels();
            List<int> expected = new List<int>(4);
            expected.Add(4);
            string s = "aaaa";

            // Act
            List<int> actual = problem_PartitionLabels.PartitionLabels(s);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PartitionLabels_WhenPassedStringOfDifferentFourChars_ReturnsListWithOneElement()
        {
            // Arrange
            Problem_PartitionLabels problem_PartitionLabels = new Problem_PartitionLabels();
            List<int> expected = new List<int>(1);
            expected.Add(1);
            expected.Add(1);
            expected.Add(1);
            expected.Add(1);
            string s = "abcd";

            // Act
            List<int> actual = problem_PartitionLabels.PartitionLabels(s);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void PartitionLabels_WhenPassedStringFromTCExample_ReturnsListWithCorrectLength()
        {
            // Arrange
            Problem_PartitionLabels problem_PartitionLabels = new Problem_PartitionLabels();
            List<int> expected = new List<int>(500);
            expected.Add(9);
            expected.Add(7);
            expected.Add(8);
            string s = "ababcbacadefegdehijhklij";

            // Act
            List<int> actual = problem_PartitionLabels.PartitionLabels(s);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void PartitionLabels_WhenPassedStringFromTCExample_ReturnsListWithCorrectValues()
        {
            // Arrange
            Problem_PartitionLabels problem_PartitionLabels = new Problem_PartitionLabels();
            List<int> expected = new List<int>(500);
            expected.Add(9);
            expected.Add(7);
            expected.Add(8);
            string s = "ababcbacadefegdehijhklij";

            // Act
            List<int> actual = problem_PartitionLabels.PartitionLabels(s);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PartitionLabels_WhenPassedStringFromLCExample2_ReturnsListWithCorrectValues()
        {
            // Arrange
            Problem_PartitionLabels problem_PartitionLabels = new Problem_PartitionLabels();
            List<int> expected = new List<int>(500);
            expected.Add(1);
            expected.Add(9);
            string s = "caedbdedda";

            // Act
            List<int> actual = problem_PartitionLabels.PartitionLabels(s);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PartitionLabels_WhenPassedStringFromLCExample3_ReturnsListWithCorrectValues()
        {
            // Arrange
            Problem_PartitionLabels problem_PartitionLabels = new Problem_PartitionLabels();
            List<int> expected = new List<int>(500);
            expected.Add(13);
            expected.Add(1);
            expected.Add(1);
            string s = "qiejxqfnqceocmy";

            // Act
            List<int> actual = problem_PartitionLabels.PartitionLabels(s);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
