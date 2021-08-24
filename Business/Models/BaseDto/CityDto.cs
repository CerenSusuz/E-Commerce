using Core.Signatures;

namespace Business.Models.BaseDto
{
    public class CityDto : IBaseDto
    {
        public string CityName { get; set; }
        public string Plaque { get; set; }
        public bool IsBlocked { get; set; }
        public int CountryId { get; set; }
    }
}