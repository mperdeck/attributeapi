using System;

namespace Data
{
    /// <summary>
    /// requires dependency checking, uniqueness checking, etc.
    /// hopefully representative of most attributes
    /// </summary>
    public class RealisticAttr
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public string Name { get; set; }
        public string RealisticExtra { get; set; }
    }
}
