using CoffeeAdmin.Application;
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
    public class CoffeeController : ControllerBase
    {
        private readonly ICoffeeService _coffeeService;
        public CoffeeController(ICoffeeService coffeeService)
        {
            _coffeeService = coffeeService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _coffeeService.Get());
        }

        ////analogy
        //[HttpDelete()]//
        //Delete()//

        //[HttpPut()]//
        //Update();

        //[HttpPost("create")]
    }
}
