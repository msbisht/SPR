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
    [Route("api/Industry")]
    public class IndustryController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public IndustryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomerType
        [HttpGet]
        public async Task<IActionResult> GetIndustry()
        {
            List<Industry> Items = await _context.Industry.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] CrudViewModel<Industry> payload)
        {
            Industry IndustryType = payload.value;
            _context.Industry.Add(IndustryType);
            _context.SaveChanges();
            return Ok(IndustryType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody] CrudViewModel<Industry> payload)
        {
            Industry IndustryType = payload.value;
            _context.Industry.Update(IndustryType);
            _context.SaveChanges();
            return Ok(IndustryType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody] CrudViewModel<Industry> payload)
        {
            Industry IndustryType = _context.Industry
                .Where(x => x.industryid == (int)payload.key)
                .FirstOrDefault();
            _context.Industry.Remove(IndustryType);
            _context.SaveChanges();
            return Ok(IndustryType);

        }
    }
}
