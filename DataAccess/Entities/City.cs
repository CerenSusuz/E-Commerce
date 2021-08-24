using System.Collections.Generic;
using Core.Signatures;

namespace DataAccess.Entities
{
    public class City : BaseEntity
    {
        public string CityName { get; set; }
        public string Plaque { get; set; }
        public bool IsBlocked { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<District> Districts { get; set; }
    }
}