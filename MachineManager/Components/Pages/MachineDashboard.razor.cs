using MachineManager.Contracts.Services;
using MachineManager.Entities;
using Microsoft.AspNetCore.Components;

namespace MachineManager.Components.Pages
{
#nullable disable
    public partial class MachineDashboard
    {
        [Inject]
        private IDataService<Machine> dataService { get; init; }
        private List<Machine> machineList = new();

        private Machine inData = new();

        protected override async Task OnInitializedAsync()
        {
            var res = await dataService.GetAllAsync();
            if (res != null && res.Data is List<Machine> data)
            {
                machineList = data;
            }
            await base.OnInitializedAsync();
        }



        private async Task AddNewTodo()
        {
            if (inData != null)
            {
                var outp = await dataService.CreateAsync(new Request<Machine>(inData));
                //todoList.Add(outp.Data);
                inData = new();
            }
        }

    }
}
