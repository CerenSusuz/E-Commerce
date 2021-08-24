using Core.Signatures;
using DataAccess.Entities;

namespace Business.Models.BaseDto
{
    public class RoleDto : IBaseDto
    {
        public int I { get; set; }
        public string Description { get; set; }
        public Rule Rule { get; set; }
        public bool IsBlocked { get; set; }
    }
}