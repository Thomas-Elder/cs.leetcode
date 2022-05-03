using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Medium
{
    /// <summary>
    /// A class for solving LeetCode problem 29. Divide Two Integers
    /// </summary>
    /// Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.
    /// The integer division should truncate toward zero, which means losing its fractional part.For example, 8.345 would be truncated to 8, and -2.7335 would be truncated to -2.
    /// 
    /// Return the quotient after dividing dividend by divisor.
    /// 
    /// Note: Assume we are dealing with an environment that could only store integers within the 32-bit signed integer range: [−231, 231 − 1]. 
    /// For this problem, if the quotient is strictly greater than 2^31 - 1, then return 2^31 - 1, and if the quotient is strictly less than -2^31, then return -2^31.
    /// 
    /// Example 1:
    /// Input: dividend = 10, divisor = 3
    /// Output: 3 
    /// Explanation: 10/3 = 3.33333.. which is truncated to 3.
    /// 
    /// Example 2:
    /// Input: dividend = 7, divisor = -3
    /// Output: -2
    /// Explanation: 7/-3 = -2.33333.. which is truncated to -2.
    /// 
    /// Constraints:
    /// -2^31 <= dividend, divisor <= 2^31 - 1
    /// divisor ! = 0
    /// 
    /// This runs on leetcode but Time Limit Exceeded!!! 
    public class DivideTwoIntegers
    {
        /// <summary>
        /// Divides the dividend by the divisor, returning a truncated quotient.
        /// </summary>
        /// A bit of a brute force approach, this basically adds the divisor to itself until the total is 
        /// larger than the dividend, and counts how many times it needs to do that. 
        /// It's slow and at the moment LeetCode complains about the speed, so another approach is needed. 
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public int Divide(int dividend, int divisor)
        {
            // Convert to longs, so we don't have to deal with the int.minValue edge case
            long longDividend = dividend;
            long longDivisor = divisor;

            // Figure out if we need the answer to be negative.
            bool negative = longDividend < 0 ^ longDivisor < 0 ? true : false;

            // Reset the dividend/divisor to be positive
            longDividend = longDividend < 0 ? -longDividend : longDividend;
            longDivisor = longDivisor < 0 ? -longDivisor : longDivisor;

            // Ok now we can just count how many times we need to add the divisor to itself before 
            // the total is larger than the dividend. 
            long total = 0, quotient = 0;

            while (total + longDivisor <= longDividend)
            {
                total = total + longDivisor;
                quotient++;
            }

            // And factor in the negativity
            quotient = negative ? -quotient : quotient;

            int result;

            // The problem specifies return values for anything >MaxValue, or <MinValue, so handle those
            if (quotient > int.MaxValue)
            {
                result = int.MaxValue;
            }
            else if (quotient < int.MinValue)
            {
                result = int.MinValue;
            }
            else
            {
                result = (int)quotient;
            }

            return result;
        }

        /// <summary>
        /// Divides the dividend by the divisor, returning a truncated quotient.
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public int Divide_RoundTwo(int dividend, int divisor)
        {
            int result = 0;
            return result;
        }
    }
}
