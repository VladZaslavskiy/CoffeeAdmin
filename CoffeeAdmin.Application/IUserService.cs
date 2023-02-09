using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAdmin.Application
{
    public interface IUserService
    {
        public Task<bool> Login(string userName, string password);
    }
}
