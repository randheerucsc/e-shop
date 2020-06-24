using System;

namespace eshop.DataAccess.Entity
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }

        // implement common operations
    }
}
