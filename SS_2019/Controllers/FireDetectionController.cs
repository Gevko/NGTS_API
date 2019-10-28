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
    public class FireDetectionCtroller : ControllerBase
    {
        SScontext _context;
        public FireDetectionCtroller(SScontext ctx)
        {
            _context = ctx;
        }

        // GET: api/FireDetection
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.FireDetection.ToListAsync());
        }

        // POST: api/FireDetection
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Ky_026 fireDetection)
        {
            if (fireDetection != null)
            {
                try
                {
                    _context.Add(fireDetection);
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
