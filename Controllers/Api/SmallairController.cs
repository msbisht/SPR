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
    [Route("api/Smallair")]
    public class SmallairController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SmallairController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomerType
        [HttpGet]
        public async Task<IActionResult> GetSmallair()
        {
            List<Smallair> Items = await _context.Smallair.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] CrudViewModel<Smallair> payload)
        {
            Smallair SmallairType = payload.value;
            _context.Smallair.Add(SmallairType);
            _context.SaveChanges();
            return Ok(SmallairType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody] CrudViewModel<Smallair> payload)
        {
            Smallair SmallairType = payload.value;
            _context.Smallair.Update(SmallairType);
            _context.SaveChanges();
            return Ok(SmallairType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody] CrudViewModel<Smallair> payload)
        {
            Smallair SmallairType = _context.Smallair
                .Where(x => x.smallairid == (int)payload.key)
                .FirstOrDefault();
            _context.Smallair.Remove(SmallairType);
            _context.SaveChanges();
            return Ok(SmallairType);

        }
    }
}

