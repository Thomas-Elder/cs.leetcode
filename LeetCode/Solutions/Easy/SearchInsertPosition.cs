using System; 

namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving Leetcode problem 35. Search Insert Position
    /// </summary>
    /// Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
    /// You must write an algorithm with O(log n) runtime complexity.
    /// 
    /// Example 1:
    /// Input: nums = [1, 3, 5, 6], target = 5
    /// Output: 2
    /// 
    /// Example 2:
    /// Input: nums = [1, 3, 5, 6], target = 2
    /// Output: 1
    /// 
    /// Example 3:
    /// Input: nums = [1, 3, 5, 6], target = 7
    /// Output: 4
    /// 
    /// Constraints:
    /// 1 <= nums.length <= 104
    /// -104 <= nums[i] <= 104
    /// nums contains distinct values sorted in ascending order.
    /// -104 <= target <= 104
    public class SearchInsertPosition
    {
        /// <summary>
        /// Given a sorted array of distinct integers and a target value, returns the index if the target is found.
        /// If not, return the index where it would be if it were inserted in order.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsert(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;

            // The complexity restriction leads me to think we want to binary tree this somehow..
            
            while (start <= end)
            {
                int mid = (start + end) / 2;

                // If the middle index is our target, return
                if (nums[mid] == target)
                {
                    return mid;

                // if mid is greater than the target, take the left sub array
                } else if (nums[mid] > target)
                {
                    end = mid - 1;

                // mid is less than the target, so take the right sub array
                } else
                {
                    start = mid + 1;
                }
            }

            // If we've made it here, end is the index below where we need to insert the target.
            return end + 1;
        }
    }
}
