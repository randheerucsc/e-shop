using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eshop.DataAccess.Entity
{
    [Table("CustomerRole")]
    public class CustomerRoleEntry : BaseEntity
    {
        [Required]
        [MaxLength(250)]
        public string RoleName { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public ICollection<CustomerEntry> CustomerEntities { get; set; }
    }
}