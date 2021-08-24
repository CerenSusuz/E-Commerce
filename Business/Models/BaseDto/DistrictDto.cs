using Core.Signatures;

namespace Business.Models.BaseDto
{
    public class DistrictDto : IBaseDto
    {
        public string DistrictName { get; set; }
        public int CityId { get; set; }
        public bool IsBlocked { get; set; }
    }
}