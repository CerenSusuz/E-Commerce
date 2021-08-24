using Core.Signatures;

namespace Business.Models.BaseDto
{
    public class CountryDto : IBaseDto
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public bool IsBlocked { get; set; }
    }
}