using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace CoffeeAdmin.Domain.Entities
{
    public class Bill: BaseEntity
    {
        public List<CoffeeInOrder> Positions { get; set; }

        //make ignore attribute
        public double SumPrice { get
            {
                return Positions.Sum(x => x.Price);
            } }
    }
}
