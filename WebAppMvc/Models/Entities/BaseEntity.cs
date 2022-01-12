using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppMvc.Models.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; set; }
        [StringLength(28)]
        public string CreatedUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        [StringLength(28)]
        public string UpdateUser { get; set; }
    }
}
