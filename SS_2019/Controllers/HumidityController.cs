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
    public class HumidityController : ControllerBase
    {
        SScontext _context;
        public HumidityController(SScontext ctx)
        {
            _context = ctx;
        }

        // GET: api/Humidity
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Humidity.ToListAsync());
        }

        // POST: api/Humidity
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Dht_11_h humidity)
        {
            if(humidity != null)
            {
                try
                {
                    _context.Add(humidity);
                    await _context.SaveChangesAsync();
                }
                catch(Exception)
                {
                    return BadRequest();
                }

                return Ok();
            }

            return BadRequest();
        }
    }
}
