using Core.Signatures;

namespace DataAccess.Entities
{
    public class Setting : BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public bool IsBlocked { get; set; }
    }
}