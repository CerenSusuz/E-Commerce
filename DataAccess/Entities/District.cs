using System.Collections.Generic;
using Core.Signatures;

namespace DataAccess.Entities
{
    public class District : BaseEntity
    {
        public string DistrictName { get; set; }
        public bool IsBlocked { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}