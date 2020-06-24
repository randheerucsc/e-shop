using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eshop.DataAccess.Entity
{
    [Table("Picture")]
    public class PictureEntity : BaseEntity
    {

        [MaxLength(250)]
        public string Description { get; set; }
        [MaxLength(250)]
        public string FilePath { get; set; }
        public byte BinaryData { get; set; }

    }
}
