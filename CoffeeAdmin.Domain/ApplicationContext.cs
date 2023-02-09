using CoffeeAdmin.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeAdmin.Domain
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Coffee> Coffees { get; set; }
        public DbSet<CoffeeInOrder> CoffeeInOrders { get; set; }
    }
}
