using CoffeeAdmin.Application;
using CoffeeAdmin.Domain.ApiModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeAdmin.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillService service;

        public BillController(IBillService service)
        {
            this.service = service;
        }

        [HttpPost("makebill")]
        public async Task<IActionResult> Create(BillBuild model)
        {
            return Ok(await service.MakeBill(model));
        }
    }
}
