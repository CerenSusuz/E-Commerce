using Core.Signatures;
using DataAccess.Entities;

namespace Business.Models.BaseListDto
{
    public class RolesDto : IBaseListDto
    {
        public string Description { get; set; }
        public Rule Rule { get; set; }
        public bool IsBlocked { get; set; }
    }
}