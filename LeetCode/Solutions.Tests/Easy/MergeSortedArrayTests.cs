using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class MergeSortedArrayTests
    {
        private readonly MergeSortedArray _mergeSortedArray;

        public MergeSortedArrayTests()
        {
            _mergeSortedArray = new MergeSortedArray();
        }

        [TestMethod]
        public void Merge_WhenPassedExample1_ReturnsExpectedArray()
        {
            // Arrange
            int[] input1 = { 1, 2, 3, 0, 0, 0 };
            int[] input2 = { 2, 5, 6 };
            int[] expected = { 1, 2, 2, 3, 5, 6 };

            int m = 3;
            int n = 3;

            // Act
            _mergeSortedArray.Merge(ref input1, m, input2, n);

            // Assert
            CollectionAssert.AreEqual(expected, input1);
        }

        [TestMethod]
        public void Scootch_WhenAskedToShiftFromIndexZero_ShiftsElements()
        {
            // Arrange
            int[] input = { 1, 0 };
            int[] expected = { 1, 1 };
            int index = 0;

            // Act
            var actual = _mergeSortedArray.Scootch(input, index);

            // Assert 
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Scootch_WhenAskedToShiftFromIndexTwo_ShiftsElements()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5, 0 };
            int[] expected = { 1, 2, 3, 3, 4, 5 };
            int index = 2;

            // Act
            var actual = _mergeSortedArray.Scootch(input, index);

            // Assert 
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
