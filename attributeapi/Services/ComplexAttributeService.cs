using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class ComplexAttributeService: AttributeService<ComplexAttr>, IComplexAttributeService
    {
        public ComplexAttributeService(DbContext dbContext) : base(dbContext)
        {

        }

        public override void Add(ComplexAttr data)
        {
        }

        public override void Update(ComplexAttr data)
        {
        }


        public override void Delete(Guid externalId)
        {

        }

    }
}
