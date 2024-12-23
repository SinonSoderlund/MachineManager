using MachineManager.Contracts.Contract;
using System.ComponentModel.DataAnnotations;

namespace MachineManager.Entities
{
    public class Machine : IGuid
    {
        public Guid Guid { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Name cannot exceed 25 characters.")]
        public string Name { get; set; } = string.Empty;
        [StringLength(120, ErrorMessage = "Data cannot exceed 120 characters.")]
        public string Data { get; set; } = string.Empty;
        public bool IsOnline { get; set; }

        public Machine(string name, string data)
        {
            Name = name;
            Data = data;
        }
        public Machine() { }
    }
}
