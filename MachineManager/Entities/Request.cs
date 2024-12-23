using MachineManager.Contracts.Request;

namespace MachineManager.Entities
{
    public class Request<T> : IRequest<T>
    {
        public T Data { get; set; }

        public Request(T data = default!)
        {
            Data = data;
        }
    }
}
