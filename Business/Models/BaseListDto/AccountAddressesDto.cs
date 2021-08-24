using Core.Signatures;
using DataAccess.Entities;

namespace Business.Models.BaseListDto
{
    public class AccountAddressesDto : IBaseListDto
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public AddressType AccountAddressType { get; set; }
    }
}