using Core.Signatures;
using DataAccess.Entities;

namespace Business.Models.BaseListDto
{
    public class AccountsDto : IBaseListDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public bool IsSuperVisor { get; set; }
        public bool IsBlocked { get; set; }
        
        public string UserGroup { get; set; }
        public string Gender { get; set; }
        public Role Role { get; set; }
    }
}