using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IAttributeService<T>: IService<T> where T : class
    {
    }
}
