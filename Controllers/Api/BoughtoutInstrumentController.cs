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
    [Route("api/BoughtoutInstrument")]
    public class BoughtoutInstrumentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BoughtoutInstrumentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomerType
        [HttpGet]
        public async Task<IActionResult> GetBoughtoutInstrument()
        {
            List<BoughtoutInstrument> Items = await _context.BoughtoutInstrument.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] CrudViewModel<BoughtoutInstrument> payload)
        {
            BoughtoutInstrument BoughtoutInstrumentType = payload.value;
            _context.BoughtoutInstrument.Add(BoughtoutInstrumentType);
            _context.SaveChanges();
            return Ok(BoughtoutInstrumentType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody] CrudViewModel<BoughtoutInstrument> payload)
        {
            BoughtoutInstrument BoughtoutInstrumentType = payload.value;
            _context.BoughtoutInstrument.Update(BoughtoutInstrumentType);
            _context.SaveChanges();
            return Ok(BoughtoutInstrumentType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody] CrudViewModel<BoughtoutInstrument> payload)
        {
            BoughtoutInstrument BoughtoutInstrumentType = _context.BoughtoutInstrument
                .Where(x => x.boughtoutid == (int)payload.key)
                .FirstOrDefault();
            _context.BoughtoutInstrument.Remove(BoughtoutInstrumentType);
            _context.SaveChanges();
            return Ok(BoughtoutInstrumentType);

        }
    }
}