using System.Collections.Generic;

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
        public IList<int> PartitionLabels(string s)
        {
            List<int> subStringLengths = new List<int>(500);
            List<char> currentSubString = new List<char>(500);

            char[] sCharArray = s.ToCharArray();

            // For each character in the array
            foreach(char c in sCharArray)
            {

                // If it's not in the current substring... 
                if (!currentSubString.Contains(c))
                {
                    // Add it in
                    currentSubString.Add(c);
                } else
                {
                    // Else add the currentSubString length to subStringLengths
                    subStringLengths.Add(currentSubString.Count);
                    currentSubString.Clear();
                    currentSubString.Add(c);
                }
            }

            subStringLengths.Add(currentSubString.Count);

            return subStringLengths;
        }
    }
}
