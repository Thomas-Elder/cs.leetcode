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
    /// The integer division should truncate toward zero, which means losing its fractional part. For example, 8.345 would be truncated to 8, and -2.7335 would be truncated to -2.
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
        /// Uses bitshifting to cut down the number of times we need to loop in order to
        /// calculate the quotient. 
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public int Divide_RoundTwo(int dividend, int divisor)
        {
            // Handle edge case.
            if (dividend == int.MinValue && divisor == -1)
            {
                return int.MaxValue;
            }

            // Convert to longs, so we don't have to deal with the int.minValue edge case
            long longDividend = dividend;
            long longDivisor = divisor;

            // Figure out if we need the answer to be negative.
            // We'll set the sign on the way out.
            bool negative = longDividend < 0 ^ longDivisor < 0 ? true : false;

            // Reset the dividend/divisor to be positive
            // Makes it easier to handle the actual calculation.
            longDividend = longDividend < 0 ? -longDividend : longDividend;
            longDivisor = longDivisor < 0 ? -longDivisor : longDivisor;

            int quotient = 0;

            // Time for some bitshift wizardry.
            //
            // EXAMPLE:
            // LOOP 1:
            // dividend 15, divisor 5
            //
            // LOOP 2:
            // dividend 5, divisor 5
            //
            // LOOP 3:
            // dividend 0, divisor 5
            // End of the outer loop.
            while (longDividend >= longDivisor)
            {
                int shift = 0;

                // Ok so here's the wizardry. We want to avoid looping over every multiple of 
                // the divisor, because if it's 1, this will take dividend number of loops, and at least
                // one possibility is a dividend of 2^31. 
                // So here we shift the divisor left, which doubles it, until it's larger than dividend, 
                // which means we get to a number bigger than the dividend in log time rather than linear.
                // Once we've found how many times we need to shift to get bigger than the dividend, we're 
                // in the ballpark of the solution.
                //
                // LOOP 1:
                // 5 is b101 in binary. So the first test here is is 15 >= b101 (which is 5).
                // It is so we increment shift then test is 15 >= b1010 (which is 10).
                // It is so we increment shift then test is 15 >= b10100 (which is 20).
                // And it is not, so the loop is over, and shift is 2.
                //
                // LOOP 2:
                // When we get here the second time, the dividend is 5, and divisor is 5.
                // So the first test is 5 >= b101
                // It is so we increment shift, then test is 5 >= b1010
                // And it is not, so the loop is over, and shift is 1.
                while (longDividend >= (longDivisor << shift))
                {
                    shift++;
                }

                // Here we add 1 left shifted by 1 less than the amount of times we needed to shift above.
                // 
                // LOOP 1:
                // shift was 2, so we left shift 1 by 1, which gives us b10, or 2.
                //
                // LOOP 2:
                // shift was 1, so we left shift 1 by 0, which gives us b1, or 1.
                quotient += (1 << (shift - 1));

                // Now we decrement the dividend by the divisor left shifted by 1 less than the amount of times
                // we needed to shift above.
                // 
                // LOOP 1:
                // shift was 2, so we left shift the divisor by 1, which gives us b1010, or 10. 
                // So now longDividend is 5.
                // 
                // LOOP 2:
                // shift was 1, so we left shift the divisor by 0, which gives us b101, or 5.
                // So now longDividend is 0.
                longDividend -= longDivisor << (shift - 1);

                // The reason we're using (shift - 1) is that shifting doubles the number, so we're exponentially
                // If in our example we just added 1 << shift to the quotient, in the first run through the
                // outer loop, we'd add 4 to the quotient. And we'd subtract 20 from the dividend giving us -5.
                // We double the divisor til it's bigger than the dividend, then go back a step, and run the 
                // loop again.
            }

            // We use the negative we set above to set the sign of the result.
            return negative ? -quotient : quotient;
        }
    }
}
