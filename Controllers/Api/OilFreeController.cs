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
    [Route("api/OilFree")]
    public class OilFreeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OilFreeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomerType
        [HttpGet]
        public async Task<IActionResult> GetOilFree()
        {
            List<OilFree> Items = await _context.OilFree.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] CrudViewModel<OilFree> payload)
        {
            OilFree OilFreeType = payload.value;
            _context.OilFree.Add(OilFreeType);
            _context.SaveChanges();
            return Ok(OilFreeType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody] CrudViewModel<OilFree> payload)
        {
            OilFree OilFreeType = payload.value;
            _context.OilFree.Update(OilFreeType);
            _context.SaveChanges();
            return Ok(OilFreeType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody] CrudViewModel<OilFree> payload)
        {
            OilFree OilFreeType = _context.OilFree
                .Where(x => x.oilfreeId == (int)payload.key)
                .FirstOrDefault();
            _context.OilFree.Remove(OilFreeType);
            _context.SaveChanges();
            return Ok(OilFreeType);

        }
    }
}
