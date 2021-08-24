using System.Data;
using Core.Signatures;

namespace DataAccess.Entities
{
    public class Role : BaseEntity
    {
        public string Description { get; set; }
        public bool IsBlocked { get; set; }
    }
}