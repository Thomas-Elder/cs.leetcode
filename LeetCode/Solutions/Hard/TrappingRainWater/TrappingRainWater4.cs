using System.Linq;
using System;

namespace Solutions
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
    /// Note:
    /// This one passes leetcode! Snappy af too. 
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

            // Handle the edge with care
            if (height.Length == 0)
                return rainfall;

            // First find the max of the array, and it's index, we'll use this to split the array into left and right halves.
            int max = height.Max();
            int maxIndex = Array.IndexOf(height, max);

            // Set up indices for the left half
            int leftStart = 0;
            int leftEnd = maxIndex - 1;
            int leftMax = 0;
            int leftMaxIndex = maxIndex;

            // Set up indices for the right half
            int rightStart = maxIndex + 1;
            int rightEnd = height.Length - 1;
            int rightMax = 0;
            int rightMaxIndex = maxIndex;

            // Handle the left side first!

            // Loop while leftEnd is > 1
            // If leftStart is 0, and leftEnd is 1, there isn't room to catch more water
            while (leftEnd > 1)
            {
                // Loop from max down to 0, to get the left-most maximum value
                for (int i = leftEnd; i >= leftStart; i--)
                {
                    if (height[i] >= leftMax)
                    {
                        leftMax = height[i];
                        leftMaxIndex = i;
                    }
                }

                // If leftMaxIndex hasn't been set above, we can break, because we haven't found a "wall" to the left
                if (leftMaxIndex > leftEnd)
                    break;

                // Reset leftStart to leftMaxIndex
                // We want to work between leftMax and the previous leftMax
                leftStart = leftMaxIndex;

                // Get total land in leftStart-leftEnd
                int sum = 0;
                for (int j = leftStart; j <= leftEnd; j++)
                    sum += height[j];

                // Get total area, and subtract land from it to get rainfall
                int totalArea = leftMax * (leftEnd - leftStart + 1);
                rainfall += totalArea - sum;

                // Reset lstart and lend, we want to shift down below leftMaxIndex
                leftEnd = leftMaxIndex - 1;
                leftStart = 0;
                leftMax = 0;
            }

            // On to the right hand side

            // Loop til rightStart is the second last index.
            // Again if rightStart is second last, and rightEnd is last, there isn't room to catch water.
            while (rightStart < height.Length - 1)
            {

                // Get rightMax and Index, this time we loop up from previous max, to the end to find the 
                // right most max
                for (int i = rightStart; i <= rightEnd; i++)
                {
                    if (height[i] >= rightMax)
                    {
                        rightMax = height[i];
                        rightMaxIndex = i;
                    }
                }

                // If rightMaxIndex wasn't set above, we can break, because there are no further walls to the right
                if (rightMaxIndex < rightStart)
                    break;

                // Reset rightEnd to rightMaxIndex
                rightEnd = rightMaxIndex;

                // Get total area, and subtract land from it to get rainfall
                int sum = 0;
                for (int j = rightStart; j <= rightEnd; j++)
                    sum += height[j];

                int totalArea = rightMax * (rightEnd - rightStart + 1);
                rainfall += totalArea - sum;

                // Reset rstart and rend, shifting past rightMaxIndex
                rightStart = rightMaxIndex + 1;
                rightEnd = height.Length - 1;
                rightMax = 0;
            }

            return rainfall;
        }

    }
}
