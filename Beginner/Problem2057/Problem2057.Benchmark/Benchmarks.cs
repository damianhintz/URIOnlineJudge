using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using Problem2057.Solution;

namespace Problem2057.Benchmark
{
    [SimpleJob(BenchmarkDotNet.Engines.RunStrategy.Monitoring)]
    public class Benchmarks
    {
        [Params(0, 23)]
        public int X { get; set; }

        [Params(1, 12)]
        public int Y { get; set; }

        [Params(-5, 5)]
        public int Z { get; set; }

        [Benchmark]
        public void GetLocalTime()
        {
            URI.GetLocalTime(X, Y, Z);
        }

        [Benchmark]
        public void GetLocalTimeArray()
        {
            URI.GetLocalTimeArray(X, Y, Z);
        }
    }
}
