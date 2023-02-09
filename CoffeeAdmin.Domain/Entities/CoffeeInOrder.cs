using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoffeeAdmin.Domain.Entities
{
    public class CoffeeInOrder: BaseEntity
    {
        [ForeignKey("CoffeeSnapshot")]
        public int CoffeeId { get; set; }

        public Coffee CoffeeSnapshot { get; set; }

        public double Price { get; set; }
    }
}
