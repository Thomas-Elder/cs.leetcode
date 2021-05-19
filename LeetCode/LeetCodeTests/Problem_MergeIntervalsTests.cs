using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System.Collections.Generic;

namespace LeetCodeTests
{
    [TestClass]
    public class Problem_MergeIntervalsTests
    {
        [TestMethod]
        public void Merge_WhenGivenTwoOverlappingIntervals_ReturnsOne()
        {
            // Arrange
            Problem_MergeIntervals problem_MergeIntervals = new Problem_MergeIntervals();
            int[][] testArray = new int[4][];
            testArray[0] = new int[] { 1,3};
            testArray[1] = new int[] { 2,6};
            testArray[2] = new int[] { 8,10};
            testArray[3] = new int[] { 15,18};

            int[][] expected = new int[3][];
            expected[0] = new int[] { 1, 6 };
            expected[1] = new int[] { 8, 10 };
            expected[2] = new int[] { 15, 18 };

            // Act
            int [][] actual = problem_MergeIntervals.Merge(testArray);

            // Assert
            Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected[0][0], actual[0][0]);
        }
    }
}
