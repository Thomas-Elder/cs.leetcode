using System.Linq;

namespace Solutions
{
    /// <summary>
    /// A class for solving Leet Code problem 56. Merge Intervals
    /// </summary>
    /// Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, 
    /// and return an array of the non-overlapping intervals that cover all the intervals in the input.
    /// 
    /// Example 1: 
    /// Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
    /// Output: [[1,6],[8,10],[15,18]]
    /// Explanation: Since intervals[1, 3] and[2, 6] overlaps, merge them into[1, 6].
    /// 
    /// Example 2:
    /// Input: intervals = [[1,4],[4,5]]
    /// Output: [[1,5]]
    /// Explanation: Intervals[1, 4] and[4, 5] are considered overlapping.
    ///
    /// Constraints:
    /// 1 <= intervals.length <= 104
    /// intervals[i].length == 2
    /// 0 <= starti <= endi <= 104
    ///
    /// Note:
    /// Currently doesn't handle this input
    /// [[1,4],[0,4]]
    public class MergeIntervals
    {
        /// <summary>
        /// Merges an array of intervals
        /// </summary>
        /// Returns an array of intervals covering all the intervals passed in but with
        /// any overlapping intervals replaced.
        /// <param name="intervals"></param>
        /// <returns></returns>
        public int [][] Merge(int [][] intervals)
        {
            int[][] result = new int [intervals.Length][];
            int resultIndex = 0;

            // Initialise the result array
            for (int i = 0; i < intervals.Length; i++)
                result[i] = new int[2];

            // Loop over each interval in intervals
            for (int i = 0; i < intervals.Length; i++)
            {
                int end = i == intervals.Length - 1 ? i : i + 1;

                if (intervals[i][1] >= intervals[end][0])
                {
                    result[resultIndex][0] = intervals[i][0];
                    result[resultIndex][1] = intervals[end][1];
                    resultIndex++;
                    i++;
                } else
                {
                    result[resultIndex][0] = intervals[i][0];
                    result[resultIndex][1] = intervals[i][1];
                    resultIndex++;
                }
            }

            // Need to prune unneeded arrays from result
            result = result.Where(element => element[0] != 0).ToArray();

            return result;
        }
    }
}
