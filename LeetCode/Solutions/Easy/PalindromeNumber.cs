using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving Leetcode problem 9. Palindrome Number
    /// </summary>
    /// Given an integer x, return true if x is palindrome integer.
    /// 
    /// An integer is a palindrome when it reads the same backward as forward.
    /// 
    /// For example, 121 is a palindrome while 123 is not.
    /// 
    /// Example 1:
    /// Input: x = 121
    /// Output: true
    /// Explanation: 121 reads as 121 from left to right and from right to left.
    /// 
    /// Example 2:
    /// Input: x = -121
    /// Output: false
    /// Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
    /// 
    /// Example 3:
    /// Input: x = 10
    /// Output: false
    /// Explanation: Reads 01 from right to left.Therefore it is not a palindrome.
    /// 
    /// Constraints:
    /// 
    /// -231 <= x <= 231 - 1
    /// 
    /// Follow up: Could you solve it without converting the integer to a string?
    /// 
    /// Passing on leetcode. Did not convert to string.
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            List <int> list = new List<int>();

            while (x != 0)
            {
                list.Add(x % 10);
                x /= 10;
            }

            // check for palindromeness
            for (int i = 0, j = list.Count - 1; i < list.Count && j >=0; i++, j--)
            {
                if (list[i] != list[j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
