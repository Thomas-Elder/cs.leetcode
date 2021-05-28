using System.Linq;
using System.Collections.Generic;
using System;

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
            // Sort the intervals on the first element
            List<int[]> list = intervals.OrderBy(element => element[0]).ToList();

            // Loop through the intervals, starting at the second index as
            // We compare to the previous index
            // [i][0] is the start if the ith interval
            // [i][1] is the end of the ith interval
            for (int i = 1; i < list.Count; i++)
            {
                // If i.start is less than i - 1.end, then these intervals overlap
                if (list[i][0] <= list[i - 1][1])
                {
                    // Then we set [i - 1].end to the larger of [i].end and [i - 1].end
                    list[i - 1][1] = list[i][1] > list[i - 1][1] ? list[i][1] : list[i - 1][1];

                    // Now we can remove i.
                    // All the information about i is contained in i - 1;
                    // We remove i, and decrement, so we can compare the new i - 1
                    // interval against subsequent intervals.
                    list.RemoveAt(i--);
                }
            }

            return list.ToArray();
        }
    }
}
