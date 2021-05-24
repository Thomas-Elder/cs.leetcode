using Problems;
using System;
using System.Diagnostics;

namespace PerformanceTesting
{
    public class TrappingRainPerformance
    {

        public void TrappingRainWater2Performance()
        {

            Console.WriteLine("Testing TrappingRainWater2s");

            // Arrange
            TrappingRainWater2 trappingRainWater2 = new TrappingRainWater2();
            Stopwatch sw = new Stopwatch();
            int[] terrain = new int[981];
            long averageRuntime = 0;
            int numberOfRuns = 10;
            int i;
            int j = 0;

            for (i = 980; i >= 0; i--)
                terrain[j++] = i;

            // Act
            for (int k = 0; k < 10; k++)
            {
                sw.Reset();
                sw.Start();
                trappingRainWater2.Rainfall(terrain);
                sw.Stop();
                averageRuntime += sw.ElapsedMilliseconds;

                Console.WriteLine("Runtime for trappingRainWater2.Rainfall run {0}: {1}", k, sw.ElapsedMilliseconds);
            }

            averageRuntime = averageRuntime / numberOfRuns;

            // Assert
            Console.WriteLine("Average runtime for trappingRainWater2.Rainfall: {0}", averageRuntime);
        }

        public void TrappingRainWater3Performance()
        {

            Console.WriteLine("Testing TrappingRainWater3");

            // Arrange
            TrappingRainWater3 trappingRainWater3 = new TrappingRainWater3();
            Stopwatch sw = new Stopwatch();
            int[] terrain = new int[981];
            long averageRuntime = 0;
            int numberOfRuns = 10;
            int i;
            int j = 0;

            for (i = 980; i >= 0; i--)
                terrain[j++] = i;

            // Act
            for (int k = 0; k < 10; k++)
            {
                sw.Reset();
                sw.Start();
                trappingRainWater3.Trap(terrain);
                sw.Stop();
                averageRuntime += sw.ElapsedMilliseconds;

                Console.WriteLine("Runtime for trappingRainWater3.Rainfall run {0}: {1}", k, sw.ElapsedMilliseconds);
            }

            averageRuntime = averageRuntime / numberOfRuns;

            // Assert
            Console.WriteLine("Average runtime for trappingRainWater3.Rainfall: {0}", averageRuntime);
        }
    }
}
