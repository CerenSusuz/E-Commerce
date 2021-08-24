using Core.Signatures;
using DataAccess.Entities;

namespace Business.Models.BaseListDto
{
    public class CitiesDto : IBaseListDto
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string Plaque { get; set; }
        public string Country { get; set; }
        public bool IsBlocked { get; set; }
    }
}