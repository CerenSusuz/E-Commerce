using Core.Signatures;
using DataAccess.Entities;

namespace Business.Models.BaseListDto
{
    public class DistrictsDto : IBaseListDto
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public string City { get; set; }
        public bool IsBlocked { get; set; }
    }
}