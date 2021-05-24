﻿using System.Linq;

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
    public class TrappingRainWater3
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

            for (int row = 0; row < height.Max(); row++)
            {
                for (int column = 0; column < height.Length; column++)
                {
                    if (height[column] <= row && LandToTheLeft(height, row, column) && LandToTheRight(height, row, column))
                    {
                        rainfall++;
                    }
                }
            }
            
            return rainfall;
        }

        /// <summary>
        /// Determines if there is land to the left of the specified co-ords
        /// </summary>
        /// <param name="height"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public bool LandToTheLeft(int [] height, int row, int column)
        {
            if (column > 0)
            {
                for (int i = column - 1; i >= 0; i--)
                {
                    if (height[i] > row)
                        return true;
                }
            } 

            return false;
        }

        /// <summary>
        /// Determines if there is land to the right of the specified co-ords
        /// </summary>
        /// <param name="height"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public bool LandToTheRight(int[] height, int row, int column)
        {
            if (column < height.Length - 1)
            {
                for (int i = column + 1; i < height.Length; i++)
                {
                    if (height[i] > row)
                        return true;
                }
            }

            return false;
        }
    }
}
