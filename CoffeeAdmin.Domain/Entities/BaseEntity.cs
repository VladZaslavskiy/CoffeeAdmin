using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeAdmin.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
