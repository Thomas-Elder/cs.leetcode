using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System.Collections.Generic;

namespace LeetCodeTests
{
    [TestClass]
    public class Problem_PartitionLabelsTests
    {

        [TestMethod]
        public void PartitionLabels_WhenPassedStringOfSameFourChars_ReturnsListWithFourElement()
        {
            // Arrange
            Problem_PartitionLabels problem_PartitionLabels = new Problem_PartitionLabels();
            IList<int> expected = new List<int>(4);
            expected.Add(1);
            expected.Add(1);
            expected.Add(1);
            expected.Add(1);
            string s = "aaaa";

            // Act
            IList<int> actual = problem_PartitionLabels.PartitionLabels(s);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void PartitionLabels_WhenPassedStringOfDifferentFourChars_ReturnsListWithOneElement()
        {
            // Arrange
            Problem_PartitionLabels problem_PartitionLabels = new Problem_PartitionLabels();
            IList<int> expected = new List<int>(1);
            expected.Add(4);
            string s = "abcd";

            // Act
            IList<int> actual = problem_PartitionLabels.PartitionLabels(s);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod]
        public void PartitionLabels_WhenPassedStringFromTCExample_ReturnsListWithCorrectLengths()
        {
            // Arrange
            Problem_PartitionLabels problem_PartitionLabels = new Problem_PartitionLabels();
            IList<int> expected = new List<int>(500);
            expected.Add(9);
            expected.Add(7);
            expected.Add(8);
            string s = "ababcbacadefegdehijhklij";

            // Act
            IList<int> actual = problem_PartitionLabels.PartitionLabels(s);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }
    }
}
