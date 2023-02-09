using CoffeeAdmin.Domain.ApiModels;
using CoffeeAdmin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeAdmin.Application
{
    public interface IBillService
    {
        public Task<Bill> MakeBill(BillBuild billInfo);
        public Task<double> GetIncome(DateTime actualDate);
    }
}
