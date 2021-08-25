using Core.Signatures;
using DataAccess.Entities;

namespace Business.Models.BaseDto
{
    public class AccountAddressDto : IBaseDto
    {
        public string Type { get; set; }
        public int AccountId { get; set; }
        public AddressType AccountAddressType { get; set; }
    }
}