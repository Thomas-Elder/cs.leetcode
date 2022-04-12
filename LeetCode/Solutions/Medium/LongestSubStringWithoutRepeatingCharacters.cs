using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Medium
{
    /// <summary>
    /// A class for solving Leetcode problem 3. Longest Substring Without Repeating Characters
    /// </summary>
    /// Given a string s, find the length of the longest substring without repeating characters.
    /// 
    /// Example 1:
    /// Input: s = "abcabcbb"
    /// Output: 3
    /// Explanation: The answer is "abc", with the length of 3.
    /// 
    /// Example 2:
    /// Input: s = "bbbbb"
    /// Output: 1
    /// Explanation: The answer is "b", with the length of 1.
    /// 
    /// Example 3:
    /// Input: s = "pwwkew"
    /// Output: 3
    /// Explanation: The answer is "wke", with the length of 3.
    /// 
    /// Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
    /// 
    /// Constraints:
    /// 0 <= s.length <= 5 * 104
    /// s consists of English letters, digits, symbols and spaces.
    public class LongestSubStringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            int result = 1;

            List<char> fullString = s.ToCharArray().ToList<char>();
            List <char> currentSubString = new List<char>();

            // trivial case
            if (s.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < fullString.Count; i++)
            {
                if (currentSubString.Contains(fullString[i]))
                {
                    // Check if this string is longer than the current result, set result
                    // to this value if it is.
                    result = currentSubString.Count > result ? currentSubString.Count : result;
                    
                    // To get the index of the previous instance of this char, we get the LastIndexOf
                    // this char in a range from fullString from 0 to i (exclusive). This is effectively
                    // the second last instance of this char.
                    int previousInstance = fullString.GetRange(0, i).LastIndexOf(fullString[i]);

                    // The new subString will start just after this previous instance
                    int startNewSubString = previousInstance + 1;

                    // And the length of the new subString the difference between this start point, 
                    // and the current index in the list. We add one to include fullString[i] in
                    // the subString.
                    int lengthNewSubString = i - startNewSubString + 1;

                    // Now empty the subString
                    currentSubString.Clear();

                    // And add the range from just after the previous instance of this char, up to 
                    // and including the current char, fullString[i].
                    currentSubString.AddRange(fullString.GetRange(startNewSubString, lengthNewSubString));
                }
                else
                {
                    // If the char is not already in the subString, add it.
                    currentSubString.Add(fullString[i]);
                }                
            }

            // If the last substring is the longest, we wont have set result to it, so take that 
            // value if it's larger than the current result.
            result = currentSubString.Count > result ? currentSubString.Count : result;

            return result;
        }
    }
}
