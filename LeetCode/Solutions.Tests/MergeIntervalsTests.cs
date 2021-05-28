using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace Solutions.Tests
{
    [TestClass]
    public class MergeIntervalsTests
    {
        [TestMethod]
        public void Merge_WhenGivenTwoOverlappingIntervals_ReturnsOne()
        {
            // Arrange
            MergeIntervals mergeIntervals = new MergeIntervals();
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
            int [][] actual = mergeIntervals.Merge(testArray);

            // Assert
            Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected[0][0], actual[0][0]);
        }

        [TestMethod]
        public void Merge_WhenGivenTwoOverlappingIntervalsLCTestCase_ReturnsCorrectResult()
        {
            // Arrange
            MergeIntervals mergeIntervals = new MergeIntervals();
            int[][] testArray = new int[2][];
            testArray[0] = new int[] { 1, 4 };
            testArray[1] = new int[] { 0, 4 };

            int[][] expected = new int[1][];
            expected[0] = new int[] { 0, 4 };

            // Act
            int[][] actual = mergeIntervals.Merge(testArray);

            // Assert
            Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected[0][0], actual[0][0]);
        }

        [TestMethod]
        public void Merge_WhenGivenTwoOverlappingIntervalsLCTestCase1_ReturnsCorrectResult()
        {
            // Arrange
            MergeIntervals mergeIntervals = new MergeIntervals();
            int[][] testArray = new int[3][];
            testArray[0] = new int[] { 1, 4 };
            testArray[1] = new int[] { 0, 2 };
            testArray[2] = new int[] { 3, 5 };

            int[][] expected = new int[1][];
            expected[0] = new int[] { 0, 5 };

            // Act
            int[][] actual = mergeIntervals.Merge(testArray);

            // Assert
            Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected[0][0], actual[0][0]);
        }

        [TestMethod]
        public void Merge_WhenGivenTwoOverlappingIntervalsLCTestCase2_ReturnsCorrectResult()
        {
            // Arrange
            MergeIntervals mergeIntervals = new MergeIntervals();
            int[][] testArray = new int[10][];
            testArray[0] = new int[] { 5, 5 };
            testArray[1] = new int[] { 1, 3 };
            testArray[2] = new int[] { 3, 5 };
            testArray[3] = new int[] { 4, 6 };
            testArray[4] = new int[] { 1, 1 };
            testArray[5] = new int[] { 3, 3 };
            testArray[6] = new int[] { 5, 6 };
            testArray[7] = new int[] { 3, 3 };
            testArray[8] = new int[] { 2, 4 };
            testArray[9] = new int[] { 0, 0 };

            int[][] expected = new int[2][];
            expected[0] = new int[] { 0, 0 };
            expected[1] = new int[] { 1, 6 };

            // Act
            int[][] actual = mergeIntervals.Merge(testArray);

            // Assert
            Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected[0][0], actual[0][0]);
        }
    }
}
