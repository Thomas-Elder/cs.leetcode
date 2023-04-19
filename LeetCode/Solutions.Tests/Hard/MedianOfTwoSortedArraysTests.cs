using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Hard;

namespace Solutions.Tests.Hard
{
    [TestClass]
    public class MedianOfTwoSortedArraysTests
    {
        private readonly MedianOfTwoSortedArrays _medianOfTwoSortedArrays;
        public MedianOfTwoSortedArraysTests()
        {
            _medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
        }

        [TestMethod]
        public void FindMedianSortedArrays_WhenGivenFirstExample_ReturnsExpectedAnswer()
        {
            // Arrange
            int [] nums1 = {1, 3};
            int[] nums2 = { 2 };
            double expected = 2.00;

            // Act
            var actual = _medianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMedianSortedArrays_WhenGivenSecondExample_ReturnsExpectedAnswer()
        {
            // Arrange
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };
            double expected = 2.50;

            // Act
            var actual = _medianOfTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
