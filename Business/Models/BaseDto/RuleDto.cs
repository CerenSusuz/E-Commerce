using Core.Signatures;

namespace Business.Models.BaseDto
{
    public class RuleDto : IBaseDto
    {
        
        public string Key { get; set; }
        public bool IsView { get; set; }
        public bool IsInsert { get; set; }
        public bool IsDelete { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsBlocked { get; set; }
        
        public int RoleId { get; set; }
    }
}