using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Medium
{
    /// <summary>
    /// A class to solve leetcode problem 6. Zigzag Conversion
    /// </summary>
    /// The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
    /// P   A   H   N
    /// A P L S I I G
    /// Y   I   R
    /// 
    /// And then read line by line: "PAHNAPLSIIGYIR"
    /// Write the code that will take a string and make this conversion given a number of rows:
    /// 
    /// string convert(string s, int numRows);
    /// 
    /// Example 1:
    /// Input: s = "PAYPALISHIRING", numRows = 3
    /// Output: "PAHNAPLSIIGYIR"
    /// 
    /// Example 2:
    /// Input: s = "PAYPALISHIRING", numRows = 4
    /// Output: "PINALSIGYAHRPI"
    /// 
    /// Explanation:
    /// P     I     N
    /// A   L S   I G
    /// Y A   H R
    /// P     I
    /// 
    /// Example 3:
    /// Input: s = "A", numRows = 1
    /// Output: "A"
    /// 
    /// Constraints:
    /// 1 <= s.length <= 1000
    /// s consists of English letters (lower-case and upper-case), ',' and '.'.
    /// 1 <= numRows <= 1000
    public class ZigZagConversion
    {
        /// <summary>
        /// Converts a string into a zigzag pattern over the given number of rows.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public string Convert(string s, int numRows)
        {
            // Trivial case of string length 1
            if (numRows == 1)
            {
                return s;
            }

            // Create jagged array, a list of StringBuilders makes it easier to add and convert back to string later
            List<StringBuilder> rows = new List<StringBuilder>();

            for (int i  = 0; i < numRows; i++)
            {
                rows.Add(new StringBuilder());
            }

            // Fill array
            // Track current row, so we know if we're going up or down
            int currentRow = 0;
            bool goingDown = false;

            foreach (char c in s)
            {
                rows[currentRow].Append(c);

                // Figure out if we need to go down, or back up
                // If we're at the top, or the bottom, we need to invert our goingDown flag
                if (currentRow == 0 || currentRow == numRows - 1)
                {
                    goingDown = !goingDown;
                }

                // Then based on that, we either increment or decrement currentRow
                currentRow += goingDown ? 1 : -1;
            }

            // Convert array to string
            var result = new StringBuilder();

            foreach (StringBuilder row in rows)
            {
                result.Append(row);
            }

            // Return
            return result.ToString();
        }
    }
}
