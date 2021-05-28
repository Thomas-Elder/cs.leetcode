using System.Linq;
using System.Collections.Generic;

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
            List<int[]> result = intervals.OrderBy(element => element[0]).ToList();
            List<int[]> temp = new List<int[]>();
            bool overlap = true;

            while (overlap)
            {
                // set overlap false here
                overlap = false;
                bool skip = false;

                for (int i = 0; i < result.Count; i++)
                {
                    int start = result[i][0];
                    int end = result[i][1];

                    // For each interval, start, end
                    // If any subsequent interval.start is less than i.end
                    // then there is overlap.
                    // Take i.start and interval.end
                    for (int j = i + 1; j < result.Count; j++)
                    {
                        if (result[i][1] >= result[j][0])
                        {
                            start = result[i][0];
                            end = result[j][1] > result[i][1] ? result[j][1] : result[i][1];

                            // We've handled an overlap
                            overlap = true;
                            skip = true;
                        }
                        
                    }

                    if (skip)
                    {
                        skip = false;
                        i++;
                    }

                    temp.Add(new int[] { start, end });
                }

                result = new List<int[]>(temp);
                temp.Clear();
            }

            return result.ToArray();
        }
    }
}
