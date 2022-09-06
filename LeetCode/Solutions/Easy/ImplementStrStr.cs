using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Easy
{
    /// <summary>
    /// A class to solve leetcode problem
    /// </summary>
    /// Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
    /// 
    /// Clarification:
    /// What should we return when needle is an empty string? This is a great question to ask during an interview.
    /// For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().
    /// 
    /// Example 1:
    /// Input: haystack = "hello", needle = "ll"
    /// Output: 2
    /// 
    /// Example 2:
    /// Input: haystack = "aaaaa", needle = "bba"
    /// Output: -1
    /// 
    /// Constraints:
    /// 1 <= haystack.length, needle.length <= 104
    /// haystack and needle consist of only lowercase English characters.
    public class ImplementStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            int result = -1;

            // trivial cases
            if (needle.Length == 0)
            {
                result = 0;
                return result;
            }

            if (!haystack.Contains(needle))
            {
                result = -1;
                return result;
            }

            if (haystack.Length == needle.Length)
            {
                result = 0;
                return result;
            }

            for (int i = 0, j = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[j])
                {
                    if (j == 0)
                    {
                        result = i;    
                    }

                    j++;
                }

                // If we've not gotten through the whole needle
                if (j < needle.Length - 1)
                {
                    // And if our haystack isn't containing the needle
                    if (haystack[i] != needle[j])
                    {
                        result = -1;
                    }
                }

                // If we're through the whole needle, return.
                if (j > needle.Length - 1)
                {
                    return result;
                }
            }

            return result;
        }
    }
}
