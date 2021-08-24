using Core.Signatures;

namespace Business.Models.BaseListDto
{
    public class SettingsDto : IBaseListDto
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public bool IsBlocked { get; set; }
    }
}