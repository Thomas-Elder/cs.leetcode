using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    /// <summary>
    /// A class for solving Leet Code problem 763. Partition Labels
    /// A string s of lowercase English letters is given.
    /// We want to partition this string into as many parts as possible so that each letter appears 
    /// in at most one part, and return a list of integers representing the size of these parts.
    /// 
    /// Example
    /// Input: s = "ababcbacadefegdehijhklij"
    /// Output: [9,7,8]
    /// Explanation:
    /// The partition is "ababcbaca", "defegde", "hijhklij".
    /// This is a partition so that each letter appears in at most one part.
    /// A partition like "ababcbacadefegde", "hijhklij" is incorrect, because it splits s into less parts.
    ///
    /// Note:
    /// s will have length in range [1, 500].
    /// s will consist of lowercase English letters ('a' to 'z') only.
    /// </summary>
    public class Problem_PartitionLabels
    {
        /// <summary>
        /// Returns a list of integers representing the length substrings with non-repeating characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public List<int> PartitionLabels(string s)
        {
            List<int> subStringLengths = new List<int>(500);
             char[] sCharArray = s.ToCharArray();

            // For each character in the array
            for (int i = 0; i < sCharArray.Length; i++)
            {
                char c = sCharArray[i];
                int start = i;
                int end = 0;

                if (start == sCharArray.Length - 1)
                    end = start;

                // Find the last occurence of this character by running backward through
                // the array from the last index.
                for (int j = sCharArray.Length - 1; j > i; j--)
                {

                    // If index j matches c, j is the new end of the string, break
                    if (sCharArray[j] == c)
                    {
                        end = j;
                        break;
                    }
                    // If we reach the i + 1st element, we've not found another c,
                    // so c is it's own substring
                    else if (j == i + 1)
                    {
                        end = i;
                        break;
                    }
                }
                
                // Take the current subString
                char [] subString = sCharArray.Skip(start).Take(end - start + 1).ToArray();

                
                // Now we've got a substring from c - last_c, but there are other chars in the
                // string, we need to check if any of them are beyond end.
                // We loop from end onward, and if any char beyond end is in the substring, we 
                // set end to it's location.
                for (int k = end; k < sCharArray.Length; k++)
                {
                    // If this substring contains k, set end to k, to include k in the subString
                    if (subString.Contains(sCharArray[k]))
                    {
                        end = k;

                        // Reset the subString because end has changed, because we want to check 
                        // the next char against the full substring.
                        subString = sCharArray.Skip(start).Take(end - start + 1).ToArray();
                    }                    
                }

                // Find the new subString length and add it to the list
                subStringLengths.Add(subString.Length);

                // Set i to end, so we start a new substring.
                i = end;
            }

            return subStringLengths;
        }
    }
}
