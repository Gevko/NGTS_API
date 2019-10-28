using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SS_2019.Models;

namespace SS_2019.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        SScontext _context;
        public TemperatureController(SScontext ctx)
        {
            _context = ctx;
        }

        // GET: api/Temperature
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Temperature.ToListAsync());
        }

        // POST: api/Temperature
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Dht_11_t temperature)
        {
            if (temperature != null)
            {
                try
                {
                    _context.Add(temperature);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {
                    return BadRequest();
                }

                return Ok();
            }

            return BadRequest();
        }
    }
}
