using MachineManager.Contracts.Data;
using MachineManager.Contracts.Repositories;
using MachineManager.Contracts.Request;
using MachineManager.Data;
using MachineManager.Entities;

namespace MachineManager.Repositories
{
#pragma warning disable CS1998
    public class VolatileMachineDataRepository : IDataRepository<Machine>
    {
        private readonly GuidList<Machine> todoList;
        public VolatileMachineDataRepository(IDataStore<GuidList<Machine>> todoStore)
        {
            todoList = todoStore.DataStore;
        }

        public async Task<IRequest<Machine>> CreateAsync(IRequest<Machine> CreateRequets)
        {
            todoList.Add(CreateRequets.Data);
            return CreateRequets;
        }

        public async Task<IRequest<Machine>> DeleteAsync(IRequest<Machine> DeleteRequets)
        {
            todoList.Remove(DeleteRequets.Data);
            return DeleteRequets;
        }

        public async Task<IRequest<IEnumerable<Machine>>> GetAllAsync()
        {
            return new Request<IEnumerable<Machine>>(todoList);
        }

        public async Task<IRequest<Machine>> GetAsync(IRequest<Machine> GetRequets)
        {
            GetRequets.Data = todoList.FirstOrDefault(t => t.Guid == GetRequets.Data.Guid)!;
            return GetRequets;
        }

        public async Task<IRequest<Machine>> UpdateAsync(IRequest<Machine> UpdateRequets)
        {
            throw new NotImplementedException();
        }
    }
}
