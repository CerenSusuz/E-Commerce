using System.Collections.Generic;
using Core.Signatures;

namespace DataAccess.Entities
{
    public class Country : BaseEntity
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public bool IsBlocked { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}