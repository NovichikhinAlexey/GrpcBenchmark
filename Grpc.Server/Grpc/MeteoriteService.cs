using Grpc.Contract;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Grpc.Server.Grpc
{
    public class MeteoriteService : IMeteoriteService
    {
        public async Task<List<MeteoriteLanding>> GetMeteoriteLandings()
        {
            return JsonSerializer.Deserialize<List<MeteoriteLanding>>(await File.ReadAllTextAsync("y77d-th95.json"), new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}
