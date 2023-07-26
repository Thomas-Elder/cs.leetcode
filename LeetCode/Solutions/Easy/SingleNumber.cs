
using System.Diagnostics;

namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving Leetcode problem 136. Single Number
    /// </summary>
    /// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
    /// You must implement a solution with a linear runtime complexity and use only constant extra space.
    /// Example 1:
    /// Input: nums = [2, 2, 1]
    /// Output: 1
    /// 
    /// Example 2:
    /// Input: nums = [4, 1, 2, 1, 2]
    /// Output: 4
    /// 
    /// Example 3:
    /// Input: nums = [1]
    /// Output: 1
    /// 
    /// Constraints:
    /// 1 <= nums.length <= 3 * 104
    /// -3 * 104 <= nums[i] <= 3 * 104
    /// Each element in the array appears twice except for one element which appears only once.
    public class SingleNumber
    {
        /// <summary>
        /// Given an array with one number only appearing once, returns that number
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int GetSingleNumber(int[] nums)
        {
            // Trivial cases
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            var result = 0;

            // Here we bitwise XOR each number with 0. 
            // If you XOR a number with itself, you get zero.
            // If you XOR a number with 0, you get the number. 
            // So in effect we add each number in the array to result, and if we come 
            // across it a second time, it is subtracted from that total, leaving us 
            // with the value of the number which appears only once.
            foreach ( var num in nums )
            {
                result ^= num;
            }

            return result;
        }
    }
}
