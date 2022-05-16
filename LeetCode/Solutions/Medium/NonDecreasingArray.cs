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

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        changes++;
                    }

                    if (changes > 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
