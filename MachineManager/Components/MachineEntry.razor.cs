using MachineManager.Contracts.Services;
using MachineManager.Entities;
using Microsoft.AspNetCore.Components;

namespace MachineManager.Components
{
    public partial class MachineEntry
    {
        [Parameter]
        public Machine data { get; init; } = default!;

        [Inject]
        private IDataService<Machine> dataService { get; init; }

        private bool active = true;
        private bool gone = false;

        private void ToggleActive()
        {
            active = !active;
        }

        private async Task DeleteThis()
        {
            await dataService.DeleteAsync(new Request<Machine>(data));
            gone = true;
        }



    }
}
