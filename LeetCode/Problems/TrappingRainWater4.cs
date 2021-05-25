using System.Linq;
using System;

namespace Problems
{
    /// <summary>
    ///  class for solving Leet Code problem 42. Trapping Rain Water
    /// </summary>
    /// Given n non-negative integers representing an elevation map where the width of each bar is 1, 
    /// compute how much water it can trap after raining.
    /// 
    /// Example 1:
    /// Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
    /// Output: 6 
    /// Explanation: The above elevation map(black section) is represented by array[0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]. 
    /// In this case, 6 units of rain water (blue section) are being trapped.
    /// 
    /// Example 2: 
    /// Input: height = [4, 2, 0, 3, 2, 5]
    /// Output: 9
    /// 
    /// Constraints: 
    /// n == height.length
    /// 0 <= n <= 3 * 104
    /// 0 <= height[i] <= 105
    /// 
    public class TrappingRainWater4
    {

        /// <summary>
        /// Takes an array of values representing terrain and returns 
        /// the amount of rainfall trapped by that terrain. 
        /// </summary>
        /// <param name="height"></param>
        /// <returns>An integer representing the amount of rain trapped by this terrain</returns>
        public int Trap(int[] height)
        {
            int rainfall = 0;

            // Find the max, save the index.
            int max = height.Max();
            int maxIndex = Array.IndexOf(height, max);

            // Take subArray from the left of index to the next left max
            int[] subArray = SubArray(height, 0, maxIndex);

            // Find the start of the sub array, the largets value left in the subArray
            int leftMax = subArray.Max();
            int end = maxIndex;
            int start = Array.IndexOf(subArray, leftMax);
            subArray = SubArray(subArray, start, end);

            while (subArray.Length > 1)
            {
                int totalArea = leftMax * subArray.Length;
                int land = subArray.Sum();
                rainfall += totalArea - land;

                // Get next subArray
                subArray = SubArray(subArray, 0, start - 1);
                end = start - 1;
                leftMax = subArray.Max();
                start = Array.IndexOf(subArray, leftMax);

                subArray = SubArray(subArray, start, end);
            }

            // Start on the right!
            subArray = SubArray(subArray, maxIndex, subArray.Length - 1);

            int rightMax = subArray.Max();
            end = Array.LastIndexOf(subArray, rightMax);
            start = 0;
            subArray = SubArray(subArray, start, end);
            // Take subArray from 0 to the lastIndexOf(max), why doesn't this work!?
            // Because it's not deleting that last values.
            //Array.Copy(subArray, start, subArray, 0, end);

            while (subArray.Length > 1)
            {
                int totalArea = rightMax * subArray.Length;
                int land = subArray.Sum();
                rainfall += totalArea - land;

                // Get next subArray
                subArray = SubArray(subArray, start, subArray.Length - 1);
                start = end + 1;
                rightMax = subArray.Max();
                end = Array.LastIndexOf(subArray, rightMax);

                subArray = SubArray(subArray, start, end);
            }

            return rainfall;
        }

        public int [] SubArray(int [] array, int start, int end)
        {
            int length = end - start + 1;
            int[] result = new int[length];
            Array.Copy(array, start, result, 0, length);

            return result;
        }
    }
}
