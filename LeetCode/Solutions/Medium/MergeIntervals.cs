using System.Linq;
using System.Collections.Generic;
using System;

namespace Solutions.Medium
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
    /// Passes LC, but it's slow. I bet there's some trick to getting as zippy result.
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

            // Loop through the intervals.
            // [i][0] is the start if the ith interval
            // [i][1] is the end of the ith interval
            for (int i = 0; i < list.Count; i++)
            {
                // For readability set next and curr
                int curr = i;
                int next = i + 1;

                // This means curr is the last element, so break;
                if (next == list.Count)
                    break;

                // If curr.end is greater than/= to next.start, then these intervals overlap
                // and we need to merge them
                if (list[curr][1] >= list[next][0])
                {
                    // Then we set [curr].end to the larger of [curr].end and [next].end
                    list[curr][1] = list[next][1] > list[curr][1] ? list[next][1] : list[curr][1];

                    // [curr].start can stay as it is, we know it's lower because we sorted on
                    // this value first.

                    // So now, all the values in the range next are contained in curr;
                    // We can remove next, and decrement, so we can compare the new curr
                    // interval against subsequent intervals.
                    list.RemoveAt(next);
                    i--;

                    // This way we stay at the start of the array until we find an element that does not
                    // over lap. Then we let it increment to work from the second interval on, etc.
                }
            }

            return list.ToArray();
        }
    }
}
