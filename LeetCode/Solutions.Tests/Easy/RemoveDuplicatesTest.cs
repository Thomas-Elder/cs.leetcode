using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;
using Utility;

namespace Solutions.Tests.Easy
{
    [TestClass]
    public class RemoveDuplicatesTest
    {
        private readonly RemoveDuplicates _removeDuplicates;

        public RemoveDuplicatesTest()
        {
            _removeDuplicates = new RemoveDuplicates();
        }

        [TestMethod]
        public void DeleteDuplicates_WhenPassedSingleNode_ReturnsSingleNode()
        {
            // Arrange
            ListNode head = new ListNode(1);

            ListNode expected = new ListNode(1);

            // Act
            var actual = _removeDuplicates.DeleteDuplicates(head);

            // Assert
            Assert.AreEqual(expected.val, actual.val);
        }

        [TestMethod]
        public void DeleteDuplicates_WhenPassedTwoIdenticalNodes_ReturnsSingleNodeAndNextIsNull()
        {
            // Arrange
            ListNode head = new ListNode(1);
            head.next = new ListNode(1);

            ListNode expected = new ListNode(1);

            // Act
            var actual = _removeDuplicates.DeleteDuplicates(head);

            // Assert
            Assert.AreEqual(expected.val, actual.val);
            Assert.IsNull(actual.next);
        }

        [TestMethod]
        public void DeleteDuplicates_WhenGivenExampleOne_ReturnsExpectedList()
        {
            // Arrange
            ListNode head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(2);

            ListNode expected = new ListNode(1);
            expected.next = new ListNode(2);

            // Act
            var actual = _removeDuplicates.DeleteDuplicates(head);

            // Assert
            Assert.AreEqual(expected.val, actual.val);
            Assert.AreEqual(expected.next.val, actual.next.val);
        }

        [TestMethod]
        public void DeleteDuplicates_WhenGivenListWithThreeDuplicateValues_ReturnsSingleNode()
        {
            // Arrange
            ListNode head = new ListNode(1);
            head.next = new ListNode(1);
            head.next.next = new ListNode(1);

            ListNode expected = new ListNode(1);

            // Act
            var actual = _removeDuplicates.DeleteDuplicates(head);

            // Assert
            Assert.AreEqual(expected.val, actual.val);
            Assert.IsNull(actual.next);
        }
    }
}
