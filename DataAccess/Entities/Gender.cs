using Core.Signatures;

namespace DataAccess.Entities
{
    public class Gender : BaseEntity
    {
        public string Description { get; set; }
        public bool IsBlocked { get; set; }
    }
}