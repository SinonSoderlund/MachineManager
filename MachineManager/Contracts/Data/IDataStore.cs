namespace MachineManager.Contracts.Data
{
    public interface IDataStore<T>
    {
        T DataStore { get; }
    }
}
