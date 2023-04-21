using BenchmarkDotNet.Running;

namespace Benchmark.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        BenchmarkRunner.Run<BenchmarkService>();
    }
}