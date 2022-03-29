using Utility;

namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving Leetcode problem 21. Merge Two Sorted Lists
    /// </summary>
    /// You are given the heads of two sorted linked lists list1 and list2.
    /// 
    /// Merge the two lists in a one sorted list.The list should be made by splicing together the nodes of the first two lists.
    /// 
    /// Return the head of the merged linked list.
    /// 
    /// Example 1:
    /// Input: list1 = [1, 2, 4], list2 = [1, 3, 4]
    /// Output: [1,1,2,3,4,4]
    /// 
    /// Example 2:
    /// Input: list1 = [], list2 = []
    /// Output: []
    /// 
    /// Example 3:
    /// Input: list1 = [], list2 = [0]
    /// Output: [0]
    /// 
    /// Constraints:
    /// The number of nodes in both lists is in the range [0, 50].
    /// -100 <= Node.val <= 100
    /// Both list1 and list2 are sorted in non-decreasing order.
    /// 
    public class MergeTwoSortedLists
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode listResult = new ListNode();
            ListNode head = listResult;

            if (list1 == null && list2 == null)
            {
                return null;
            }

            while (list1 != null || list2 != null)
            {
                if (list1 is null)
                {
                    listResult.val = list2.val;
                    list2 = list2.next;

                } else if (list2 is null)
                {
                    listResult.val = list1.val;
                    list1 = list1.next;

                } else if (list1.val < list2.val)
                {
                    listResult.val = list1.val;
                    list1 = list1.next;
                } else
                {
                    listResult.val = list2.val;
                    list2 = list2.next;
                }

                if (list1 != null || list2 != null)
                {
                    listResult.next = new ListNode();
                    listResult = listResult.next;
                }
            }

            return head;
        }
    }
}
