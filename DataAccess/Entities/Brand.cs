using Core.Signatures;

namespace DataAccess.Entities
{
    public class Brand : BaseEntity
    {
        public string Description { get; set; }
        public string Url { get; set; }
        public bool IsBlocked { get; set; }
    }
}