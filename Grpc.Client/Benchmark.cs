using BenchmarkDotNet.Attributes;
using Grpc.Contract;
using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Grpc.Client
{

    [MemoryDiagnoser]
    public class Benchmark
    {
        readonly HttpClient _httpClient;
        readonly IMeteoriteService _service;
        public Benchmark()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:5001")
            };

            _service = GrpcChannel.ForAddress("https://localhost:5001").CreateGrpcService<IMeteoriteService>();
        }

        [Params(100, 200)]
        public int IterationCount;

        [Benchmark]
        public async Task<string> HttpCall()
        {
            for(var i = 0; i < IterationCount; i++)
            {
                await _httpClient.GetStringAsync("Calculator/MeteoriteLandings");
            }
            return "OK";
        }

        [Benchmark]
        public async Task<string> GrpcCall()
        {
            for (var i = 0; i < IterationCount; i++)
            {
                await _service.GetMeteoriteLandings();
            }
            return "OK";
        }
    }
}
