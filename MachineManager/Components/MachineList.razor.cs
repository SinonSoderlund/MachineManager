using MachineManager.Entities;
using Microsoft.AspNetCore.Components;

namespace MachineManager.Components
{
    public partial class MachineList
    {
        [Parameter]
        public List<Machine> machines { get; set; } = [];

    }
}
