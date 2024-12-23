using MachineManager.Contracts.Services;
using MachineManager.Entities;
using Microsoft.AspNetCore.Components;

namespace MachineManager.Components.Pages
{
    public partial class AddNewMachine
    {
        public Machine machine = new();

        [Inject]
        private IDataService<Machine> dataService { get; init; } = default!;

        [Inject]
        private NavigationManager navigationManager { get; set; } = default!;
        public async void addNewMachine()
        {
            await dataService.CreateAsync(new Request<Machine>(machine));
            navigationManager.NavigateTo("/");
        }

    }
}
