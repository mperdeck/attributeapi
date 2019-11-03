using System;

namespace Services
{
    public interface IService<T> where T : class
    {
        void Add(T data);
        void Delete(Guid externalId);
        T Get(Guid externalId);
        void Update(T data);
    }
}