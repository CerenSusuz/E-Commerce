using Core.Signatures;

namespace Business.Models.BaseDto
{
    public class SettingDto : IBaseDto
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public bool IsBlocked { get; set; }
    }
}