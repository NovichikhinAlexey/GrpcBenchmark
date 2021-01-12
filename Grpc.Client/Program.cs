using BenchmarkDotNet.Running;
using System.Threading.Tasks;

namespace Grpc.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmark>();
        }
    }
}
