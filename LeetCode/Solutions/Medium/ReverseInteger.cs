using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Medium
{

    /// <summary>
    /// A class for solving LeetCode problem 7. Reverse Integer
    /// </summary>
    /// 
    /// Given a signed 32-bit integer x, return x with its digits reversed.If reversing x causes the value 
    /// to go outside the signed 32-bit integer range[-231, 231 - 1], then return 0.
    /// 
    /// Assume the environment does not allow you to store 64-bit integers(signed or unsigned).
    /// 
    /// Example 1:
    /// Input: x = 123
    /// Output: 321
    /// 
    /// Example 2:
    /// Input: x = -123
    /// Output: -321
    /// 
    /// Example 3:
    /// Input: x = 120
    /// Output: 21
    ///  
    /// Constraints:
    /// -231 <= x <= 231 - 1
    public class ReverseInteger
    {

        public int Reverse(int x)
        {
            // convert to string? 
            var xCharArray = x.ToString().ToCharArray();
            var resultCharArray = new char[xCharArray.Length];

            int i = 0, j = xCharArray.Length - 1;

            if (xCharArray[0] == '-')
            {
                resultCharArray[0] = '-';
                i++;
            }

            while (i < xCharArray.Length)
            {
                resultCharArray[j--] = xCharArray[i++];
            }

            var result = 0;

            int.TryParse(resultCharArray, out result);

            return result;
        }
    }
}
