using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class AttributeService<T>: Service<T>, IAttributeService<T> where T : class
    {
    }
}
