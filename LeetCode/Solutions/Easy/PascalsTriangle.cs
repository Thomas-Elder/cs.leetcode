using System.Collections.Generic;

namespace Solutions.Easy
{
    public class PascalsTriangle
    {
        /// <summary>
        /// Given an integer numRows, returns the first numRows of Pascal's triangle.
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                var row = new List<int>();

                // If i == 0, first row, is always just 1
                if (i == 0)
                {
                    row.Add(1);
                } else if (i == 1)
                {
                    row.Add(1);
                    row.Add(1);
                } else
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

            return result;
        }
    }
}
