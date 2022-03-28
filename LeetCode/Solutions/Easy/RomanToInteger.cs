using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving Leetcode problem 13. Roman to Integer
    /// </summary>
    /// 
    /// Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
    ///
    /// Symbol Value
    /// I             1
    /// V             5
    /// X             10
    /// L             50
    /// C             100
    /// D             500
    /// M             1000
    /// For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is 
    /// simply X + II. The number 27 is written as XXVII, which is XX + V + II.
    ///
    /// Roman numerals are usually written largest to smallest from left to right.However, the numeral for four is not IIII. 
    /// Instead, the number four is written as IV.
    /// Because the one is before the five we subtract it making four. The same principle applies to the number nine, 
    /// which is written as IX.There are six instances where subtraction is used:
    ///
    /// I can be placed before V (5) and X(10) to make 4 and 9. 
    /// X can be placed before L(50) and C(100) to make 40 and 90. 
    /// C can be placed before D(500) and M(1000) to make 400 and 900.
    /// Given a roman numeral, convert it to an integer.
    ///
    /// Example 1:
    /// 
    /// Input: s = "III"
    /// Output: 3
    /// Explanation: III = 3.
    /// Example 2:
    /// 
    /// Input: s = "LVIII"
    /// Output: 58
    /// Explanation: L = 50, V= 5, III = 3.
    /// Example 3:
    /// 
    /// Input: s = "MCMXCIV"
    /// Output: 1994
    /// Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
    /// 
    /// Constraints:
    /// 
    /// 1 <= s.length <= 15
    /// s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
    /// It is guaranteed that s is a valid roman numeral in the range[1, 3999].
    ///
    /// Result - Passing, but ugly!! Fast but memory high. 
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            // Parse string, catching leading I, X and D 
            // Might need to track two characters at a time? This char, and the next char...

            var charArray = s.ToCharArray();
            var result = 0;

            for (int i = 0, j = 1; i < charArray.Length; i++, j++)
            {
                // If j is after the last char, we only need to add i
                if (j != charArray.Length)
                {
                    // If j == v or x, and i == i, then we want to subtract it... 
                    if ((charArray[j] == 'V' || charArray[j] == 'X') && charArray[i] == 'I')
                    {
                        result += map[charArray[j]] - map[charArray[i]];
                        i++;
                        j++;
                    }

                    // If j == L or C, and i == X, then we want to subtract it... 
                    else if ((charArray[j] == 'L' || charArray[j] == 'C') && charArray[i] == 'X')
                    {
                        result += map[charArray[j]] - map[charArray[i]];
                        i++;
                        j++;
                    }

                    // If j == D or M, and i == C, then we want to subtract it... 
                    else if ((charArray[j] == 'D' || charArray[j] == 'M') && charArray[i] == 'C')
                    {
                        result += map[charArray[j]] - map[charArray[i]];
                        i++;
                        j++;
                    }

                    else
                    {
                        result += map[charArray[i]];
                    }
                }
                else
                {
                    result += map[charArray[i]];
                }
            }

            return result;
        }
    }
}
