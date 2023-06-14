
using System;
using System.Collections.Generic;

namespace Solutions.Easy
{
    /// <summary>
    /// A class for solving leetcode problem 19. Pascal's Triangle II
    /// </summary>
    /// Given an integer rowIndex, return the rowIndexth(0-indexed) row of the Pascal's triangle.
    /// 
    /// Example 1:
    /// Input: rowIndex = 3
    /// Output: [1,3,3,1]
    /// 
    /// Example 2:
    /// Input: rowIndex = 0
    /// Output: [1]
    /// 
    /// Example 3:
    /// Input: rowIndex = 1
    /// Output: [1,1]
    /// 
    /// Constraints:
    /// 0 <= rowIndex <= 33
    public class PascalsTriangleII
    {
        /// <summary>
        /// Returns a List of integers representing the rowIndex-th row of Pascals Triangle.
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public IList<int> GetRow(int rowIndex)
        {
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i <= rowIndex; i++)
            {
                var row = new List<int>();

                // If i == 0, first row, is always just 1
                if (i == 0)
                {
                    row.Add(1);
                }
                else if (i == 1)
                {
                    row.Add(1);
                    row.Add(1);
                }
                else
                {
                    // Add first cell
                    row.Add(1);

                    for (int j = 1; j < i; j++)
                    {
                        // sum previous row's ints
                        var sum = result[i - 1][j - 1] + result[i - 1][j];
                        row.Add(sum);
                    }

                    // Add last cell
                    row.Add(1);
                }

                result.Add(row);
            }

            return result[rowIndex];
        }
    }
}
