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
            Console.WriteLine();
            trp.TrappingRainWater2Performance();
            Console.WriteLine();
            trp.TrappingRainWater3Performance();
            Console.WriteLine();
            trp.TrappingRainWater4Performance();
            Console.ReadLine();
        }
    }
}
