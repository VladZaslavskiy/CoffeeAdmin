using CoffeeAdmin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAdmin.Application
{
    public interface ICoffeeService
    {
        public Task<IEnumerable<Coffee>> Get();
        public Task<int> Create(Coffee coffee);
        public Task Update(Coffee coffee);
        public Task<Coffee> Delete(int id);
    }
}
