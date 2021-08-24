using Core.Signatures;

namespace DataAccess.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Url { get; set; }
        public bool IsBlocked { get; set; }
        public int? ParentId { get; set; }
        public Category Parent { get; set; }
    }
}