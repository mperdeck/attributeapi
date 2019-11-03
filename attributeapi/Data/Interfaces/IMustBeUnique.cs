using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    /// <summary>
    /// Data classes that implement this interface
    /// must have a unique field that is not Name.
    /// </summary>
    public interface IMustBeUnique<T>
    {
        /// <summary>
        /// Returns an expression that when used in a Linq query against the database
        /// returns one or more elements if this element is not unique.
        /// </summary>
        /// <returns></returns>
        Func<T, bool> UniquenessExpression();
    }
}
