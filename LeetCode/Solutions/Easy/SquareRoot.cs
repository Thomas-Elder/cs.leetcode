using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving leetcode problem 69. Sqrt(x)
    /// </summary>
    /// Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.
    /// You must not use any built-in exponent function or operator.
    /// For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
    /// 
    /// Example 1:
    /// Input: x = 4
    /// Output: 2
    /// Explanation: The square root of 4 is 2, so we return 2.
    /// 
    /// Example 2:
    /// Input: x = 8
    /// Output: 2
    /// Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.
    /// 
    /// Constraints:
    /// 0 <= x <= 231 - 1
    /// 
    public class SquareRoot
    {
        public int MySqrt(int x)
        {
            // trivial cases
            if (x == 0) return 0;
            if (x == 1) return 1;

            // Binary search structure
            int start = 0;
            int end = x / 2;

            while (start < end)
            {
                // Halfway between start and end numbers
                int middle = (start + (end - start) / 2) + 1;

                // If x/middle == middle, then middle is the square root
                if (x / middle == middle) return middle;

                // If x/middle > middle, then the sqrt has to be higher than middle
                // So we move start to the middle, and work between that and the end
                if (x / middle > middle) start = middle;

                // If x/middle<middle, then the sqrt has to be lower than middle
                // So we move the end to just under the middle, and loop
                if (x / middle < middle) end = middle - 1;
            }

            return start;
        }
    }
}
