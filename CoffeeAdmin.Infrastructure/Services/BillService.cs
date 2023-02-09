using CoffeeAdmin.Application;
using CoffeeAdmin.Domain;
using CoffeeAdmin.Domain.ApiModels;
using CoffeeAdmin.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAdmin.Infrastructure.Services
{
    public class BillService : IBillService
    {
        private readonly ApplicationContext _db;
        public BillService(ApplicationContext db)
        {
            _db = db;
        }

        public Task<double> GetIncome(DateTime actualDate)//get
        {
            return  Task.FromResult(_db.Bills.Where(x => x.Created.Year == actualDate.Year && x.Created.Month == actualDate.Month && x.Created.Day == actualDate.Day)
                .ToList()
                .Sum(x => x.SumPrice));
        }

        public async Task<Bill> MakeBill(BillBuild billInfo)//post
        {
            var entities = new List<CoffeeInOrder>();
           foreach(var entity in billInfo.positions)
            {
                var coffee = await _db.Coffees.FindAsync(entity.CoffeeId);
                for(var i = 0; i<entity.Quontity; i++)
                {
                    var ent = new CoffeeInOrder()
                    {
                        CoffeeId = entity.CoffeeId,
                        Created = DateTime.Now,
                        Price = coffee.Price,
                        Updated = DateTime.Now
                    };

                    entities.Add(ent);
                }

            }

            var bill = new Bill();
            bill.Positions = entities;
            bill.Created = DateTime.Now;
            bill.Updated = DateTime.Now;

            await _db.Bills.AddAsync(bill);

            await _db.SaveChangesAsync();

            return bill;
            
        }
    }
}
