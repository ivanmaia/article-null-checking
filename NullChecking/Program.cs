using BenchmarkDotNet.Running;

namespace NullChecking;

internal class Program
{
    private static void Main(string[] args)
    {
        BenchmarkRunner.Run<DemoNullChecking>();
    }
}