using Core.Signatures;

namespace DataAccess.Entities
{
    public class Rule : BaseEntity
    {
        public string Key { get; set; }
        public bool IsView { get; set; }
        public bool IsInsert { get; set; }
        public bool IsDelete { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsBlocked { get; set; }
        
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}