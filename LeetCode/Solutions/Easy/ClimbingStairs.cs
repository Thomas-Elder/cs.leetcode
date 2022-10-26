using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving leetcode problem 70. Climbing Stairs
    /// </summary>
    /// You are climbing a staircase. It takes n steps to reach the top.
    /// Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
    /// Example 1:
    /// Input: n = 2
    /// Output: 2
    /// Explanation: There are two ways to climb to the top.
    /// 1. 1 step + 1 step
    /// 2. 2 steps
    /// 
    /// Example 2:
    /// Input: n = 3
    /// Output: 3
    /// Explanation: There are three ways to climb to the top.
    /// 1. 1 step + 1 step + 1 step
    /// 2. 1 step + 2 steps
    /// 3. 2 steps + 1 step
    /// 
    /// Constraints:
    /// 1 <= n <= 45
    public class ClimbingStairs
    {
        /// <summary>
        /// Returns the number of combinations of 2 and 1 steps which can be taken to 
        /// climb a set of n stairs.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairs(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            return fibonacci(n - 1);
        }

        public int fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int current = 1;
            int previous = 1;
            int temp = 0;

            for (int i = 1; i <= n; i++)
            {
                temp = current;
                current += previous;
                previous = temp;
            }

            return current;
        }
    }
}
