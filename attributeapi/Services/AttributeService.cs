using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class AttributeService<T>: Service<T>, IAttributeService<T> where T : class, new()
    {
        public AttributeService(DbContext dbContext) : base(dbContext)
        {

        }

        public override void Add(T data)
        {
            EnsureUniqueness(data);

            base.Add(data);
        }

        public override void Update(T data)
        {
            EnsureUniqueness(data);

            base.Update(data);
        }


        public override void Delete(Guid externalId)
        {

        }

        /// <summary>
        /// Throws exception if the data has to be unique, and it isn't.
        /// </summary>
        /// <param name="data"></param>
        private void EnsureUniqueness(T data)
        {
            if (typeof(T) is IMustBeUniqueByName)
            {
                var dataAsMustBeUniqueByName = data as IMustBeUniqueByName;
                if (_dbContext.Set<T>().Cast<IMustBeUniqueByName>().Any(
                    d=>(d.Name == dataAsMustBeUniqueByName.Name) && (d.Id != dataAsMustBeUniqueByName.Id)))
                {
                    throw new ApplicationException("The name {dataAsMustBeUniqueByName.Name} is already being used.");
                }
            }

            if (typeof(T) is IMustBeUnique<T>)
            {
                var dataAsMustBeUnique = data as IMustBeUnique<T>;
                var uniquenessExpression = dataAsMustBeUnique.UniquenessExpression();

                if (_dbContext.Set<T>().Any(uniquenessExpression))
                {
                    throw new ApplicationException("The name {dataAsMustBeUniqueByName.Name} is already being used.");
                }
            }
        }
    }
}
