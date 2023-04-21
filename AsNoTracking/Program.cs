using BenchmarkDotNet.Running;

namespace AsNoTracking;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        BenchmarkRunner.Run<BencmarkService>();
    }
}