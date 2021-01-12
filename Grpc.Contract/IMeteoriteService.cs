using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Grpc.Contract
{
    [ServiceContract]
    public interface IMeteoriteService
    {
        Task<List<MeteoriteLanding>> GetMeteoriteLandings();
    }
}
