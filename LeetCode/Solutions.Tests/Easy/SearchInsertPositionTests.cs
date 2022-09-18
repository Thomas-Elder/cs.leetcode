using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class SearchInsertPositionTests
    {
        private readonly SearchInsertPosition _searchInsertPosition;

        public SearchInsertPositionTests()
        {
            _searchInsertPosition = new SearchInsertPosition();
        }

        [TestMethod]
        public void SearchInsert_WhenCalledWithTargetAtFirstIndex_Returns0()
        {
            // Arrange
            int [] nums = new int[] { 1, 2, 3 };
            int target = 1;
            int expected = 0;

            // Act
            int actual = _searchInsertPosition.SearchInsert(nums, target);
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SearchInsert_WhenCalledWithTargetShouldBeInsertedAt1_Returns1()
        {
            // Arrange
            int[] nums = new int[] { 1, 3, 3 };
            int target = 2;
            int expected = 1;

            // Act
            int actual = _searchInsertPosition.SearchInsert(nums, target);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
