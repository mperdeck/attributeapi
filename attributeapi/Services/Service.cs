using Microsoft.EntityFrameworkCore;
using System;

namespace Services
{
    /// <summary>
    /// Super basic CRUD service, direct to database
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Service<T> : IService<T> where T : class, new()
    {
        protected readonly DbContext _dbContext;

        public Service(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual T Get(Guid externalId)
        {
            return new T();
        }

        public virtual void Add(T data)
        {

        }

        public virtual void Update(T data)
        {

        }


        public virtual void Delete(Guid externalId)
        {

        }
    }
}
