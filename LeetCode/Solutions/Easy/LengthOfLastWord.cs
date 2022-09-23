
namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving leetcode problem 58. Length of Last Word
    /// </summary>
    /// Given a string s consisting of words and spaces, return the length of the last word in the string.
    /// A word is a maximal substring consisting of non-space characters only.
    /// 
    /// Example 1:
    /// Input: s = "Hello World"
    /// Output: 5
    /// Explanation: The last word is "World" with length 5.
    /// 
    /// Example 2:
    /// Input: s = "   fly me   to   the moon  "
    /// Output: 4
    /// Explanation: The last word is "moon" with length 4.
    /// 
    /// Example 3:
    /// Input: s = "luffy is still joyboy"
    /// Output: 6
    /// Explanation: The last word is "joyboy" with length 6.
    /// 
    /// Constraints:
    /// 1 <= s.length <= 104
    /// s consists of only English letters and spaces ' '.
    /// There will be at least one word in s.
    public class LengthOfLastWord
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLastWordMethod(string s)
        {
            int lastLength = 0;
            int currentLength = 0;

            foreach (char c in s)
            {
                if (c == ' ')
                {
                    lastLength = currentLength > 0 ? currentLength : lastLength;
                    currentLength = 0;
                } else
                {
                    currentLength++;
                }
            }

            // If we've still got a currentLength, then the last character of the string
            // is not a space, and therefore the currentLength is the length of the last 
            // word in the string.
            lastLength = currentLength > 0 ? currentLength : lastLength;

            return lastLength;
        }
    }
}
