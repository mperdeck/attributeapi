using System;

namespace Services
{
    /// <summary>
    /// Super basic CRUD service, direct to database
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Service<T> : IService<T> where T : class, new()
    {
        public T Get(Guid externalId)
        {
            return new T();
        }

        public void Add(T data)
        {

        }

        public void Update(T data)
        {

        }


        public void Delete(Guid externalId)
        {

        }
    }
}
