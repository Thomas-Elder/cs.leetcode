using System;

namespace PerformanceTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Performance testing LeetCode solutions.");
            Console.WriteLine();

            TrappingRainPerformance trp = new TrappingRainPerformance();
            trp.TrappingRainWater2Performance();
            trp.TrappingRainWater3Performance();
            Console.ReadLine();
        }
    }
}
