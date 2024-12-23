namespace MachineManager.Contracts.Request
{
    public interface IRequest<T>
    {
        T Data { get; set; }

    }
}
