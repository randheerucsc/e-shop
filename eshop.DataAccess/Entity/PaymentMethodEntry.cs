using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eshop.DataAccess.Entity
{
    [Table("PaymentMethod")]
    public class PaymentMethodEntry : BaseEntity
    {

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
