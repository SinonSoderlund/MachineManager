using MachineManager.Contracts.Data;
using MachineManager.Entities;

namespace MachineManager.Data
{
    public class VolatileMachineDataStore : IDataStore<GuidList<Machine>>
    {
        public GuidList<Machine> DataStore { get; }

        public VolatileMachineDataStore()
        {
            DataStore = new GuidList<Machine>();
        }


    }
}
