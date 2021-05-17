using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCodeTests
{
    [TestClass]
    public class Problem_AddTwoNumbersTests
    {
        [TestMethod]
        public void Add_WhenGivenTwoListNodes_ReturnsLinkedListWithCorrectLength()
        {
            // Arrange
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            int expected = 3;
            int actual = 0;

            // Act
            ListNode result = Problem_AddTwoNumbers.Add(l1, l2);
            
            while (result != null)
            {
                actual++;
                result = result.next;
            }

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_WhenGivenTwoListNodes_ReturnsLinkedListWithCorrectValues()
        {
            // Arrange
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            int [] expected = {7, 0, 8};
            int i = 0;

            // Act
            ListNode actual = Problem_AddTwoNumbers.Add(l1, l2);

            // Assert
            while (actual != null)
            {
                Assert.AreEqual(expected[i++], actual.val);
                actual = actual.next;
            }
        }

        [TestMethod]
        public void Add_WhenGivenTwoListNodesWithCarryOver_ReturnsLinkedListWithCorrectLength()
        {
            // Arrange
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(6);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            int expected = 4;
            int actual = 0;

            // Act
            ListNode result = Problem_AddTwoNumbers.Add(l1, l2);

            while (result != null)
            {
                actual++;
                result = result.next;
            }

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_WhenGivenTwoListNodesWithCarryOver_ReturnsLinkedListWithCorrectValues()
        {
            // Arrange
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(6);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            int[] expected = { 7, 0, 1, 1 };
            int i = 0;

            // Act
            ListNode actual = Problem_AddTwoNumbers.Add(l1, l2);

            // Assert
            while (actual != null)
            {
                Assert.AreEqual(expected[i++], actual.val);
                actual = actual.next;
            }
        }
    }
}
