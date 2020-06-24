using System;
using System.ComponentModel.DataAnnotations;

namespace eshop.DataAccess.Entity
{
    public interface IBaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        // define common operations
    }
}
