using Core.Signatures;

namespace Business.Models.BaseListDto
{
    public class RulesDto : IBaseListDto
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public bool IsView { get; set; }
        public bool IsInsert { get; set; }
        public bool IsDelete { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsBlocked { get; set; }
        public string Role { get; set; }
    }
}