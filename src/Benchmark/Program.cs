using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<Sample>();

public class Sample
{
    [Benchmark]
    public string SoDomething()
    {
        var sb = new StringBuilder();

        for (var i = 0; i < 10_000; i++)
        {
            sb.AppendLine($"Adding {i}");
        }

        return sb.ToString();
    }
}
