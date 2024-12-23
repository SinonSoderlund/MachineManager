using MachineManager.Contracts.Contract;

namespace MachineManager.Data
{
    public class GuidList<T> : List<T> where T : IGuid
    {
        public new void Add(T item)
        {
            item.Guid = Guid.NewGuid();
            base.Add(item);
        }

    }
}
