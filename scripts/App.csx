#! "netcoreapp2.1"
#r "nuget:BenchmarkDotNet,0.10.14"

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

[MemoryDiagnoser]
public class Test {

    int[] values = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

    [Benchmark]
    public void Take() {
        var a = values.Skip(5).Count();
    }

    [Benchmark]
    public void Slice() {
        var span = new Span<int>(values, 0);
        var a = span.Slice(5, span.Length - 5).Length;
    }
}

BenchmarkRunner.Run<Test>();
