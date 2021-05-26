using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    /// <summary>
    /// Sum of All Subset XOR Totals
    /// </summary>
    /// The XOR total of an array is defined as the bitwise XOR of all its elements, or 0 if the array is empty.
    /// For example, the XOR total of the array[2, 5, 6] is 2 XOR 5 XOR 6 = 1.
    /// Given an array nums, return the sum of all XOR totals for every subset of nums.
    /// 
    /// Note: Subsets with the same elements should be counted multiple times.
    /// 
    /// An array a is a subset of an array b if a can be obtained from b by deleting some (possibly zero) elements of b.
    /// 
    /// Example 1:
    /// Input: nums = [1, 3]
    /// Output: 6
    /// Explanation: The 4 subsets of [1,3] are:
    /// - The empty subset has an XOR total of 0.
    /// - [1] has an XOR total of 1.
    /// - [3] has an XOR total of 3.- [1,3] has an XOR total of 1 XOR 3 = 2.
    /// 0 + 1 + 3 + 2 = 6
    /// 
    /// Example 2:
    /// Input: nums = [5, 1, 6]
    /// Output: 28
    /// Explanation: The 8 subsets of [5,1,6] are:
    /// - The empty subset has an XOR total of 0.
    /// - [5] has an XOR total of 5.
    /// - [1] has an XOR total of 1.
    /// - [6] has an XOR total of 6.
    /// - [5,1] has an XOR total of 5 XOR 1 = 4.
    /// - [5,6] has an XOR total of 5 XOR 6 = 3.
    /// - [1,6] has an XOR total of 1 XOR 6 = 7.
    /// - [5,1,6] has an XOR total of 5 XOR 1 XOR 6 = 2.
    /// 0 + 5 + 1 + 6 + 4 + 3 + 7 + 2 = 28
    /// 
    /// Example 3:
    /// Input: nums = [3, 4, 5, 6, 7, 8]
    /// Output: 480
    /// Explanation: The sum of all XOR totals for every subset is 480.
    /// 
    /// Constraints:
    /// 1 <= nums.length <= 12
    /// 1 <= nums[i] <= 20
    ///
    public class SumOfAllSubsetXORTotals
    {
        /// <summary>
        /// Given an array nums, returns the sum of all XOR totals for every subset of nums. 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SubsetXORSum(int[] nums)
        {
            int result = 0;

            int subLength = nums.Length;

            // Then get all array subsets... 
            // Ok for each index, we'll add it's XOR to the result, then... big breath
            // we XOR it with every index after this one.
            for (int i = 0; i < nums.Length; i++)
            {
                // Add this element to the result. The XOR of a single element is just it's value.
                result += nums[i];


                // This loop XORs all subArrays starting at i.
                // So that's XOR([i.. i + 1]), XOR([i.. i + 2]), XOR([i.. i + 3]), ... XOR([i.. i + nums.Length - i]);
                while (subLength > 1)
                {
                    // Use this to XOR all elements in the subArray
                    int subXOR = nums[i];

                    for (int j = i + 1; j < subLength + i; j++)
                    {
                        subXOR ^= nums[j];
                    }

                    result += subXOR;
                    subLength--;
                }

                subLength = nums.Length - i - 1;

                // Ok then we need to XOR i with each individual index after it, starting from 2 after this one! 
                for (int j = i + 2; j < nums.Length; j++)
                {
                    result += nums[i] ^ nums[j];
                }
            }

            return result;
        }
    }
}
