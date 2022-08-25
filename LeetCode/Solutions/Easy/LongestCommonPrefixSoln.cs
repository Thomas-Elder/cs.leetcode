using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving Leetcode problem 14. Longest Common Prefix
    /// </summary>
    /// 
    /// Write a function to find the longest common prefix string amongst an array of strings.
    /// 
    /// If there is no common prefix, return an empty string "".
    /// 
    /// Example 1:
    /// Input: strs = ["flower", "flow", "flight"]
    /// Output: "fl"
    /// 
    /// Example 2:
    /// Input: strs = ["dog", "racecar", "car"]
    /// Output: ""
    /// Explanation: There is no common prefix among the input strings.
    /// 
    /// Constraints:
    /// 1 <= strs.length <= 200
    /// 0 <= strs[i].length <= 200
    /// strs[i] consists of only lowercase English letters.
    /// 
    public class LongestCommonPrefixSoln
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string result = "";

            // get shortest string length
            int shortestStringLength = strs[0].Length;

            foreach(string str in strs)
            {
                if (str.Length < shortestStringLength) 
                { 
                    shortestStringLength = str.Length; 
                }
            }

            // loop through indices up to that length, through each str
            for (int i = 0; i < shortestStringLength; i++)
            {
                // Grab the ith char of the first string, we need all strings to have this char at the ith indice
                char currentChar = strs[0][i];

                // We'll use this later to test if we've made it through all strs
                bool common = true;

                foreach (string str in strs)
                {
                    // If this strs ith char doesn't == the currentChar, we can break, and we know we've
                    // added as many chars to result as we can.
                    if (str[i] != currentChar)
                    {
                        common = false;
                        break;
                    }
                }

                if (common)
                {
                    result = result + currentChar;
                } else
                {
                    break;
                }
            }

            return result;
        }
    }
}
