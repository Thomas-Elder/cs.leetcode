using System;

namespace Solutions.Medium
{
    /// <summary>
    /// Class for solving leetcode problem 11. Container With Most Water
    /// </summary>
    /// You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
    /// Find two lines that together with the x-axis form a container, such that the container contains the most water.
    /// 
    /// Return the maximum amount of water a container can store
    /// 
    /// Notice that you may not slant the container.
    /// 
    /// Example 1:
    /// Input: height = [1, 8, 6, 2, 5, 4, 8, 3, 7]
    /// Output: 49
    /// Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
    /// 
    /// Example 2: 
    /// Input: height = [1, 1]
    /// Output: 1
    /// 
    /// Constraints:
    /// n == height.length
    /// 2 <= n <= 105
    /// 0 <= height[i] <= 104
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            // get the start and end indices
            int left = 0;
            int right = height.Length - 1;

            // track maxArea
            int maxArea = 0;
            
            while (left < right)
            {
                // find the area between the current indices
                // save in maxArea if it's bigger than maxArea
                // increment the index with the smaller height
                var area = Math.Min(height[left], height[right]) * (right - left);

                if (area > maxArea)
                {
                    maxArea = area;
                }

                // Advance whichever index has the lower value
                if (height[left] < height[right])
                {
                    left++;
                } else
                {
                    right--;
                }
            }

            return maxArea;
        }
    }
}
