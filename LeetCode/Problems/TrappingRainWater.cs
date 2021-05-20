using System.Linq;

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

    public class TrappingRainWater
    {
        /// <summary>
        /// Takes an array of values representing terrain and returns 
        /// the amount of rainfall trapped by that terrain. 
        /// </summary>
        /// <param name="terrain">An array of integers</param>
        /// <returns>In integer representing the amount of rain trapped by this terrain</returns>
        public int Rainfall(int[] terrain)
        {
            int rainfall = 0;

            bool[,] map = ConvertTo2DArray(terrain);

            for (int i = 0; i < terrain.Max(); i++)
            {
                for (int j = 0; j < terrain.Length; j++)
                {
                    // If i,j isn't land, and there's land to the left and right, then 
                    // it's water.
                    if (!map[i, j] && LandToTheLeft(map, i, j) && LandToTheRight(map, i, j))
                    {
                        rainfall++;
                    }
                }
            }

            return rainfall;
        }

        /// <summary>
        /// Converts the 1D terrain into a 2D map
        /// </summary>
        /// <param name="terrain">A 1 dimensional array describing the terrain height</param>
        /// <returns>A 2 dimensional array of boolean values</returns>
        public bool[,] ConvertTo2DArray(int[] terrain)
        {
            bool[,] a = new bool[terrain.Max(), terrain.Length];

            // For each column, set a [i, j] to true (land) if we're below the value of terrain[j],
            // else set to false (no land)
            for (int j = 0; j < terrain.Length; j++)
            {
                for (int i = 0; i < terrain.Max(); i++)
                {
                    if (terrain[j] > i)
                    {
                        a[i, j] = true;
                    }
                    else
                    {
                        a[i, j] = false;
                    }
                }
            }

            return a;
        }

        /// <summary>
        /// Checks if any index to the left of j, in row i, is true
        /// </summary>
        /// <param name="map">A 2 dimensional array</param>
        /// <param name="i">The row coordinate in the map</param>
        /// <param name="j">The column coordinate in the map</param>
        /// <returns>True if any cell to the left of j in row i, is 1. Otherwise false.</returns>
        public bool LandToTheLeft(bool[,] map, int i, int j)
        {
            if (j > 0)
            {
                for (int k = j - 1; k >= 0; k--)
                {
                    if (map[i, k])
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Checks if any index to the right of j, in row i, is true
        /// </summary>
        /// <param name="map">A 2 dimensional array</param>
        /// <param name="i">The row coordinate in the map</param>
        /// <param name="j">The column coordinate in the map</param>
        /// <returns>True if any cell to the right of j in row i, is 1. Otherwise false.</returns>
        public bool LandToTheRight(bool[,] map, int i, int j)
        {
            if (j < map.GetLength(1) - 1)
            {
                for (int k = j + 1; k < map.GetLength(1); k++)
                {
                    if (map[i, k])
                        return true;
                }
            }
            return false;
        }
    }
}
