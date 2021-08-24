using Core.Signatures;

namespace Business.Models.BaseListDto
{
    public class CountriesDto : IBaseListDto
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public bool IsBlocked { get; set; }
    }
}