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
    [Route("api/BusinessDivision")]
    public class BusinessDivisionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BusinessDivisionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomerType
        [HttpGet]
        public async Task<IActionResult> GetBusinessDivision()
        {
            List<BusinessDivision> Items = await _context.BusinessDivision.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] CrudViewModel<BusinessDivision> payload)
        {
            BusinessDivision BusinessDivisionType = payload.value;
            _context.BusinessDivision.Add(BusinessDivisionType);
            _context.SaveChanges();
            return Ok(BusinessDivisionType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody] CrudViewModel<BusinessDivision> payload)
        {
            BusinessDivision BusinessDivisionType = payload.value;
            _context.BusinessDivision.Update(BusinessDivisionType);
            _context.SaveChanges();
            return Ok(BusinessDivisionType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody] CrudViewModel<BusinessDivision> payload)
        {
            BusinessDivision BusinessDivisionType = _context.BusinessDivision
                .Where(x => x.divisionId == (int)payload.key)
                .FirstOrDefault();
            _context.BusinessDivision.Remove(BusinessDivisionType);
            _context.SaveChanges();
            return Ok(BusinessDivisionType);

        }
    }
}

