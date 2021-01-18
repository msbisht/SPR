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
    [Route("api/Facility")]
    public class FacilityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FacilityController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomerType
        [HttpGet]
        public async Task<IActionResult> GetFacility()
        {
            List<Facility> Items = await _context.Facility.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] CrudViewModel<Facility> payload)
        {
            Facility FacilityType = payload.value;
            _context.Facility.Add(FacilityType);
            _context.SaveChanges();
            return Ok(FacilityType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody] CrudViewModel<Facility> payload)
        {
            Facility FacilityType = payload.value;
            _context.Facility.Update(FacilityType);
            _context.SaveChanges();
            return Ok(FacilityType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody] CrudViewModel<Facility> payload)
        {
            Facility FacilityType = _context.Facility
                .Where(x => x.facilityid == (int)payload.key)
                .FirstOrDefault();
            _context.Facility.Remove(FacilityType);
            _context.SaveChanges();
            return Ok(FacilityType);

        }
    }
}


