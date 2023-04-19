
using System;

namespace Solutions.Hard
{
    /// <summary>
    /// A class for solving Leetcode problem 4. Median of Two Sorted Arrays
    /// </summary>
    /// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
    /// The overall run time complexity should be O(log (m+n)).
    /// 
    /// Example 1:
    /// Input: nums1 = [1,3], nums2 = [2]
    /// Output: 2.00000
    /// Explanation: merged array = [1, 2, 3] and median is 2.
    /// 
    /// Example 2:
    /// Input: nums1 = [1,2], nums2 = [3,4]
    /// Output: 2.50000
    /// Explanation: merged array = [1, 2, 3, 4] and median is (2 + 3) / 2 = 2.5.
    /// 
    /// Constraints:
    /// nums1.length == m
    /// nums2.length == n
    /// 0 <= m <= 1000
    /// 0 <= n <= 1000
    /// 1 <= m + n <= 2000
    /// -106 <= nums1[i], nums2[i] <= 106
    public class MedianOfTwoSortedArrays
    {
        /// <summary>
        /// Returns the median value from the combined sorted array.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // figure out if the total length will be odd or even. 
            int totalLength = nums1.Length + nums2.Length;

            if (totalLength % 2 == 0)
            {
                // if it's even we need to find the average of the elements at totalLength / 2
                // and (totalLength / 2) + 1
                int tempLength = (totalLength / 2) + 1;

                int i = 0;
                int j = 0;
                int k = 0;
                double [] temp = new double[tempLength];

                while (i < (totalLength / 2) + 1)
                {
                    if (j < nums1.Length && k < nums2.Length)
                    {
                        if ((nums1[j] < nums2[k]))
                        {
                            temp[i++] = nums1[j++];
                        } else
                        {
                            temp[i++] = nums2[k++];
                        }
                    } else if (j < nums1.Length)
                    {
                        temp[i++] = nums1[j++];
                    } else
                    {
                        temp[i++] = nums2[k++];
                    }
                }

                return (temp[tempLength - 1] + temp[tempLength - 2]) / 2;
            }
            else
            {
                // if it's odd, we just need to take the ((totalLength / 2).ceiling) element 
                // of the combined sorted array
                int tempLength = (totalLength / 2) + 1;

                int i = 0;
                int j = 0;
                int k = 0;
                int[] temp = new int[tempLength];

                while (i < (totalLength / 2) + 1)
                {
                    if (j < nums1.Length && k < nums2.Length)
                    {
                        if ((nums1[j] < nums2[k]))
                        {
                            temp[i++] = nums1[j++];
                        }
                        else
                        {
                            temp[i++] = nums2[k++];
                        }
                    }
                    else if (j < nums1.Length)
                    {
                        temp[i++] = nums1[j++];
                    }
                    else
                    {
                        temp[i++] = nums2[k++];
                    }
                }

                return temp[tempLength - 1];
            }
        }
    }
}
