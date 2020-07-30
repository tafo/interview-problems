using System;
using BenchmarkDotNet.Running;

namespace Interview.Benchmark
{
    internal class Program
    {
        private static void Main()
        {
            Console.ReadLine();
            BenchmarkRunner.Run(typeof(WordBreakBenchmark));
            Console.ReadLine();
        }
    }
}