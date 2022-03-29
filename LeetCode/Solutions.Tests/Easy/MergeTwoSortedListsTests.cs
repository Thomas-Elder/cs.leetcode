using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility;
using Solutions.Easy;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class MergeTwoSortedListsTests
    {
        private readonly MergeTwoSortedLists _mergeTwoSortedLists;

        public MergeTwoSortedListsTests()
        {
            _mergeTwoSortedLists = new MergeTwoSortedLists();
        }

        /// <summary>
        /// Example 1:
        /// Input: list1 = [1, 2, 4], list2 = [1, 3, 4]
        /// Output: [1,1,2,3,4,4]
        /// </summary>
        [TestMethod]
        public void MergeTwoLists_WhenGivenFirstLeetCodeExample_ReturnsCorrectOutput()
        {
            // Arrange
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            // Act
            var result = _mergeTwoSortedLists.MergeTwoLists(l1, l2);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.val);
        }

        /// <summary>
        /// Example 2:
        /// Input: list1 = [], list2 = []
        /// Output: []
        /// </summary>
        [TestMethod]
        public void MergeTwoLists_WhenGivenSecondLeetCodeExample_ReturnsCorrectOutput()
        {
            // Arrange
            ListNode l1 = null;

            ListNode l2 = null;

            // Act
            var result = _mergeTwoSortedLists.MergeTwoLists(l1, l2);

            // Assert
            Assert.IsNull(result);
        }

        /// <summary>
        /// Example 3:
        /// Input: list1 = [], list2 = [0]
        /// Output: [0]
        /// </summary>
        [TestMethod]
        public void MergeTwoLists_WhenGivenThirdLeetCodeExample_ReturnsCorrectOutput()
        {
            // Arrange
            ListNode l1 = null;

            ListNode l2 = new ListNode(0);

            // Act
            var result = _mergeTwoSortedLists.MergeTwoLists(l1, l2);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.val);
        }

        /// <summary>
        /// Example 4:
        /// Input: list1 = [-2,5], list2 = [-9,-6,-3,-1,1,6]
        /// Output: [-9,-6,-3,-2,-1,1,5,6]
        /// </summary>
        [TestMethod]
        public void MergeTwoLists_WhenGivenFourthLeetCodeExample_ReturnsCorrectOutput()
        {
            // Arrange
            ListNode l1 = new ListNode(-2);
            l1.next = new ListNode(5);

            ListNode l2 = new ListNode(-9);
            l2.next = new ListNode(-6);
            l2.next.next = new ListNode(-3);
            l2.next.next.next = new ListNode(-1);
            l2.next.next.next.next = new ListNode(1);
            l2.next.next.next.next.next = new ListNode(6);

            // Act
            var result = _mergeTwoSortedLists.MergeTwoLists(l1, l2);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(-9, result.val);
        }
    }
}
