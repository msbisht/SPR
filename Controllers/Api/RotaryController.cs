using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPR.Data;
using SPR.Models;
using SPR.Models.SyncfusionViewModels;

namespace SPR.Controllers.Api
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Rotary")]
    public class RotaryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RotaryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomerType
        [HttpGet]
        public async Task<IActionResult> GetRotary()
        {
            List<Rotary> Items = await _context.Rotary.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] CrudViewModel<Rotary> payload)
        {
            Rotary RotaryType = payload.value;
            _context.Rotary.Add(RotaryType);
            _context.SaveChanges();
            return Ok(RotaryType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody] CrudViewModel<Rotary> payload)
        {
            Rotary RotaryType = payload.value;
            _context.Rotary.Update(RotaryType);
            _context.SaveChanges();
            return Ok(RotaryType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody] CrudViewModel<Rotary> payload)
        {
            Rotary RotaryType = _context.Rotary
                .Where(x => x.rotaryid == (int)payload.key)
                .FirstOrDefault();
            _context.Rotary.Remove(RotaryType);
            _context.SaveChanges();
            return Ok(RotaryType);

        }
    }
}


