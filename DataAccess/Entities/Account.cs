using System.Collections.Generic;
using Core.Signatures;

namespace DataAccess.Entities
{
    public class Account : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsSuperVisor { get; set; }
        public ICollection<AccountAddress> AccountAddresses { get; set; }
        public ICollection<FavoriteProduct> FavoriteProducts { get; set; }
        public byte[] PasswordSalt { get; set; } 
        public byte[] PasswordHash { get; set; }
        
        public int UserGroupId { get; set; }
        public int? GenderId { get; set; }
        public int RoleId { get; set; }
        public UserGroup UserGroup { get; set; }
        public Gender Gender { get; set; }
        public Role Role { get; set; }
        
    }
}