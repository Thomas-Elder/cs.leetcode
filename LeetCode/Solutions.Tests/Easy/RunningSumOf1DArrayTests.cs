using Microsoft.VisualStudio.TestTools.UnitTesting;

using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class RunningSumOf1DArrayTests
    {

        [TestMethod]
        public void RunningSum_WhenPassedLCExample1_ReturnsCorrectResult()
        {
            // Arrange
            RunningSumOf1DArray runningSumOf1DArray = new RunningSumOf1DArray();
            int[] nums = { 1, 2, 3, 4 };
            int[] expected = { 1, 3, 6, 10 };

            // Act
            int[] actual = runningSumOf1DArray.RunningSum(nums);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RunningSum_WhenPassedLCExample2_ReturnsCorrectResult()
        {
            // Arrange
            RunningSumOf1DArray runningSumOf1DArray = new RunningSumOf1DArray();
            int[] nums = { 1, 1, 1, 1, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            int[] actual = runningSumOf1DArray.RunningSum(nums);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RunningSum_WhenPassedLCExample3_ReturnsCorrectResult()
        {
            // Arrange
            RunningSumOf1DArray runningSumOf1DArray = new RunningSumOf1DArray();
            int[] nums = { 3, 1, 2, 10, 1 };
            int[] expected = { 3, 4, 6, 16, 17 };

            // Act
            int[] actual = runningSumOf1DArray.RunningSum(nums);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
