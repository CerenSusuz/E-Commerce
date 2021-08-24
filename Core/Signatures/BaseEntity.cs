using System;

namespace Core.Signatures
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedUser { get; set; }
        public string UpdatedUser { get; set; }
    }
}