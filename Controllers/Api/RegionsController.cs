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
    [Route("api/Regions")]
    public class RegionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomerType
        [HttpGet]
        public async Task<IActionResult> GetRegion()
        {
            List<Region> Items = await _context.Region.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] CrudViewModel<Region> payload)
        {
            Region RegionType = payload.value;
            _context.Region.Add(RegionType);
            _context.SaveChanges();
            return Ok(RegionType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody] CrudViewModel<Region> payload)
        {
            Region RegionType = payload.value;
            _context.Region.Update(RegionType);
            _context.SaveChanges();
            return Ok(RegionType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody] CrudViewModel<Region> payload)
        {
            Region RegionType = _context.Region
                .Where(x => x.regionid == (int)payload.key)
                .FirstOrDefault();
            _context.Region.Remove(RegionType);
            _context.SaveChanges();
            return Ok(RegionType);

        }
    }
}
