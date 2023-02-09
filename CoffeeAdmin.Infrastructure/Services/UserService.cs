using CoffeeAdmin.Application;
using CoffeeAdmin.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAdmin.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationContext _db;
        public UserService(ApplicationContext db)
        {
            _db = db;
        }

        public Task<bool> Login(string userName, string password)//get
        {
            throw new NotImplementedException();
        }
    }
}
