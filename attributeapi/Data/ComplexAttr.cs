using System;

namespace Data
{
    /// <summary>
    /// requires special measures. member of the 20%.
    /// </summary>
    public class ComplexAttr
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public string Name { get; set; }
        public string ComplexExtra { get; set; }
    }
}
