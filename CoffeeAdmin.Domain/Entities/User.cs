using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeAdmin.Domain.Entities
{
    public class User: BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
