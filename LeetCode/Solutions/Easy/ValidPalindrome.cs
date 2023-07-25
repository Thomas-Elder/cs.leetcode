
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving leetcode problem 125. Valid Palindrome
    /// </summary>
    /// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all 
    /// non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
    /// 
    /// Given a string s, return true if it is a palindrome, or false otherwise.
    /// 
    /// Example 1:
    /// Input: s = "A man, a plan, a canal: Panama"
    /// Output: true
    /// Explanation: "amanaplanacanalpanama" is a palindrome.
    /// 
    /// Example 2:
    /// Input: s = "race a car"
    /// Output: false
    /// Explanation: "raceacar" is not a palindrome.
    /// 
    /// Example 3:
    /// Input: s = " "
    /// Output: true
    /// Explanation: s is an empty string "" after removing non-alphanumeric characters.
    /// Since an empty string reads the same forward and backward, it is a palindrome.
    /// 
    /// Constraints:
    /// 1 <= s.length <= 2 * 105
    /// s consists only of printable ASCII characters.
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            var result = false;

            // Trivial case
            if (s.Length == 0 || s.Length == 1) 
            {
                return true;
            }

            // strip and convert
            string convertedString = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();

            var i = 0;
            var j = convertedString.Length - 1;

            while (i < j)
            {
                if (convertedString[i] != convertedString[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }
}
