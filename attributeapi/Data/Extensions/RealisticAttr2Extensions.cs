using System;

namespace Data
{
    /// <summary>
    /// requires dependency checking, uniqueness checking, etc.
    /// hopefully representative of most attributes
    /// </summary>
    public partial class RealisticAttr2: IMustBeUnique<RealisticAttr2>
    {
        public Func<RealisticAttr2, bool> UniquenessExpression()
        {
            return (RealisticAttr2 d) => ((d.SomeName == SomeName) && (d.Id != Id));
        }
    }
}
