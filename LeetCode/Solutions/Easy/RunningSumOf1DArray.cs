using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving Leet Code problem 1480. Running Sum of 1d Array
    /// </summary>
    /// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
    /// Return the running sum of nums.
    /// 
    /// Example 1:
    /// Input: nums = [1, 2, 3, 4]
    /// Output: [1,3,6,10]
    /// 
    /// Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
    /// 
    /// Example 2:
    /// Input: nums = [1, 1, 1, 1, 1]
    /// Output: [1,2,3,4,5]
    /// 
    /// Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
    /// 
    /// Example 3:
    /// Input: nums = [3, 1, 2, 10, 1]
    /// Output: [3,4,6,16,17]
    /// 
    /// Constraints:
    /// 1 <= nums.length <= 1000
    /// -10^6 <= nums[i] <= 10^6
    /// 
    /// NOTE: Passes LeetCode, looks kinda slow compared to other submissions.
    public class RunningSumOf1DArray
    {

        /// <summary>
        /// Returns the running sum of the passed array.
        /// </summary
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] RunningSum(int[] nums)
        {
            int N = nums.Length;
            int [] RunningSum = new int [N];

            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    RunningSum[i] = nums[i];
                }
                else
                {
                    RunningSum[i] = RunningSum[i - 1] + nums[i];
                }
            }

            return RunningSum;
        }
    }
}
