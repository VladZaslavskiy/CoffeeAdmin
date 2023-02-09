using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeAdmin.Domain.Entities
{
    public class Coffee : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
