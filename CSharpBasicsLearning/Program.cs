using BenchmarkDotNet.Running;
namespace CSharpBasicsLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BenchmarkRunner.Run<TestBenchMarker>();
        }
    }
}
