using System.Collections.Generic;

namespace Solutions
{
    public class TrappingRainWater
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
        /// NOTE:
        /// This algorithm works for the example above, but does not solve all Leet Code tests. 
        /// Specifically, it doesn't identify local minimums that span multiple indicies, and it doesn't handle
        /// cases where two or more local minimums are part of a larger 'lake'.
        public int Trap(int[] height)
        {
            int n = height.Length;
            int rainfall = 0;
            int min = height[0];
            int max = height[0];
            List<int> localMinimums = new List<int>();

            // Let's get a list of localMinimums
            // We only look at 1->n-2 because 0 and n-1 cannot hold water
            for (int i = 1; i < n - 1; i++)
            {
                // Check if the prev and next elements are greater, and add i if both are
                if (height[i - 1] > height[i] && height[i + 1] > height[i])
                {
                    localMinimums.Add(i);
                }
            }

            // For each localMinimum go back and forward through the array to find localMaximums
            for (int i = 0; i < localMinimums.Count; i++)
            {
                int leftMax = i;
                int rightMax = i;

                // Search down the array from localMinimums[i]
                for (int j = localMinimums[i]; j > 0; j--)
                {
                    // If the next element is smaller than this one, we've reached the end
                    // of the local maximum, and we can break;
                    if (height[j - 1] < height[j])
                    {
                        break;
                    }

                    // Otherwise if the next element is bigger, set leftMax to that index.
                    if (height[j - 1] > height[j])
                    {
                        leftMax = j - 1;
                    }
                }

                // Search up the array from localMinimums[i]
                for (int j = localMinimums[i]; j < n - 1; j++)
                {
                    // If the next element is smaller than this one, we've reached the end
                    // of the local maximum, and we can break;
                    if (height[j + 1] < height[j])
                    {
                        break;
                    }

                    // Otherwise if the next element is bigger, set rightMax to that index.
                    if (height[j + 1] > height[j])
                    {
                        rightMax = j + 1;
                    }
                }

                // Now let's make a rectangle based on the local maximums (height), and their distance apart (width)
                // We only want the lowest local maxium between left and right, because the lowest one dictates how
                // much water the local minimum holds. 
                int h = height[leftMax] < height[rightMax] ? height[leftMax] : height[rightMax];
                int w = rightMax - leftMax + 1;
                int totalArea = h * w;

                // Then we need to sum the heights within that width, to see how much space the height
                // takes up.
                int sumHeights = 0;

                for (int j = leftMax; j <= rightMax; j++)
                {
                    // Add the height height, if its less than height
                    // Because heights above the local maximum don't hold more water
                    sumHeights += height[j] < h ? height[j] : h;
                }


                // Then the amount of rain captured in this local minimum is the total rectangle area, minus the 
                // height area. Add this to the running total rainfall.
                rainfall += totalArea - sumHeights;
            }

            return rainfall;
        }
    }
}
