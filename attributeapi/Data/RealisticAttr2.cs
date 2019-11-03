using System;

namespace Data
{
    /// <summary>
    /// requires dependency checking, uniqueness checking, etc.
    /// hopefully representative of most attributes
    /// </summary>
    public partial class RealisticAttr2
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public string SomeName { get; set; }   // <<<<< different property name for name
        public string RealisticExtra { get; set; }
    }
}
