using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Medium
{
    /// <summary>
    /// A class for solving LeetCode problem 665. Non-decreasing Array
    /// </summary>
    /// Given an array nums with n integers, your task is to check if it could become non-decreasing by modifying at most one element.
    /// We define an array is non-decreasing if nums[i] <= nums[i + 1] holds for every i(0-based) such that(0 <= i <= n - 2).
    /// 
    /// Example 1:
    /// Input: nums = [4,2,3]
    /// Output: true
    /// Explanation: You could modify the first 4 to 1 to get a non-decreasing array.
    /// 
    /// Example 2:
    /// Input: nums = [4, 2, 1] 
    /// Output: false 
    /// Explanation: You can't get a non-decreasing array by modify at most one element.
    /// 
    /// Constraints:
    /// n == nums.length
    /// 1 <= n <= 104
    /// -105 <= nums[i] <= 105
    /// 
    public class NonDecreasingArray
    {

        public bool CheckPossibility(int[] nums)
        {
            var changes = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                // If this index is less than the previous index, we've got a decreasing situation
                if (nums[i] < nums[i - 1])
                {
                    // increment changes counter and if we're past 1, the array cannot be sorted in 
                    // non-decreasing order with only 1 change. 
                    changes++;
                    if (changes > 1)
                    {
                        return false;
                    }

                    // Ok but there's more to look at than just two elements. We need to look at previous and 
                    // subsequent indicies before we can be sure we can make a change to make it non-decreasing. 
                    // In short if the index prior to the two we're comparing above (i and i-1), and the index 
                    // after those two, are both between i and i-1 in value, it's not possible to move just one
                    // index and make it non-decreasing.
                    // So if this situation exists, we return false. 
                    if ((i > 1 && i < nums.Length - 1 && nums[i - 2] > nums[i] && nums[i + 1] < nums[i - 1]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
