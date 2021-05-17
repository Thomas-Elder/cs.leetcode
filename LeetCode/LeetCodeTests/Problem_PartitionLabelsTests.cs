using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System.Collections.Generic;

namespace LeetCodeTests
{
    [TestClass]
    public class Problem_PartitionLabelsTests
    {

        [TestMethod]
        public void PartitionLabels_WhenPassedStringOfSameChars_ReturnsListWithOneElement()
        {
            // Arrange
            Problem_PartitionLabels problem_PartitionLabels = new Problem_PartitionLabels();
            IList<int> expected = new List<int>(1);
            expected.Add(4);
            string s = "aaaa";

            // Act
            IList<int> actual = problem_PartitionLabels.PartitionLabels(s);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
        }
    }
}
