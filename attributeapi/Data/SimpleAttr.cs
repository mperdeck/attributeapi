using System;

namespace Data
{
    /// <summary>
    /// only requires simple crud.
    /// no checking for duplicates, dependencies, etc.
    /// </summary>
    public class SimpleAttr
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public string Name { get; set; }
        public string SimpleExtra { get; set; }
    }
}
