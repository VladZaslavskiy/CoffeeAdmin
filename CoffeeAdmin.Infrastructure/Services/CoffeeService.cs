using CoffeeAdmin.Application;
using CoffeeAdmin.Domain;
using CoffeeAdmin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAdmin.Infrastructure.Services
{
    public class CoffeeService : ICoffeeService
    {
        private readonly ApplicationContext _db;
        public CoffeeService(ApplicationContext db)
        {
            _db = db;
        }
        public Task<int> Create(Coffee coffee)
        {
            throw new NotImplementedException();
        }

        public Task<Coffee> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Coffee>> Get()
        {
            throw new NotImplementedException();
        }

        public Task Update(Coffee coffee)
        {
            throw new NotImplementedException();
        }
    }
}
