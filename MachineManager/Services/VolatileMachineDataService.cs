using MachineManager.Contracts.Repositories;
using MachineManager.Contracts.Request;
using MachineManager.Contracts.Services;
using MachineManager.Entities;

namespace MachineManager.Services
{
    public class VolatileMachineDataService : IDataService<Machine>
    {
        private readonly IDataRepository<Machine> repository;
        public VolatileMachineDataService(IDataRepository<Machine> _repository)
        {
            repository = _repository;
        }
        public async Task<IRequest<Machine>> CreateAsync(IRequest<Machine> CreateRequets)
        {
            return await repository.CreateAsync(CreateRequets);
        }

        public async Task<IRequest<Machine>> DeleteAsync(IRequest<Machine> DeleteRequets)
        {
            return await repository.DeleteAsync(DeleteRequets);
        }

        public async Task<IRequest<IEnumerable<Machine>>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<IRequest<Machine>> GetAsync(IRequest<Machine> GetRequets)
        {
            return await repository.GetAsync(GetRequets);
        }

        public async Task<IRequest<Machine>> UpdateAsync(IRequest<Machine> UpdateRequets)
        {
            return await repository.UpdateAsync(UpdateRequets);
        }
    }
}
