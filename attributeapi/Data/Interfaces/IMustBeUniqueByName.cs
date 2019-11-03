using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    /// <summary>
    /// Data classes that implement this interface
    /// </summary>
    public interface IMustBeUniqueByName
    {
        int Id { get; }
        string Name { get; }
    }
}
