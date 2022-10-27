using Utility;

namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving leetcode problem 83. Remove Duplicates from Sorted List
    /// </summary>
    /// Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.
    /// 
    /// Example 1:
    /// Input: head = [1,1,2]
    /// Output: [1,2]
    /// 
    /// Example 2:
    /// Input: head = [1,1,2,3,3]
    /// Output: [1,2,3]
    /// 
    /// Constraints:
    /// The number of nodes in the list is in the range[0, 300].
    /// -100 <= Node.val <= 100
    /// The list is guaranteed to be sorted in ascending order.
    public class RemoveDuplicates
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            // Trivial cases
            // Empty list
            if (head == null) return null;

            // Only one element in list
            if (head.next == null) return head;

            // So we want to traverse the list, and given it's sorted, we can just 
            // remove any node who's value is the same as the previous node.
            // We'll keep head separate for returning later.
            ListNode currentNode = head;

            while (currentNode.next is not null)
            {
                // If the next node has the same value, then we want to skip it, that is set currentNode.next 
                // to the next.next node, if it exists, or null otherwise.
                if (currentNode.next.val == currentNode.val)
                {
                    currentNode.next = currentNode.next.next;
                }
                else
                {
                    currentNode = currentNode.next is not null ? currentNode.next : currentNode;
                }
            }

            return head;
        }
    }
}
