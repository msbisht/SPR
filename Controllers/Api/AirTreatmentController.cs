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
    [Route("api/AirTreatment")]
    public class AirTreatmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AirTreatmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomerType
        [HttpGet]
        public async Task<IActionResult> GetAirTreatment()
        {
            List<AirTreatment> Items = await _context.AirTreatment.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] CrudViewModel<AirTreatment> payload)
        {
            AirTreatment AirTreatmentType = payload.value;
            _context.AirTreatment.Add(AirTreatmentType);
            _context.SaveChanges();
            return Ok(AirTreatmentType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody] CrudViewModel<AirTreatment> payload)
        {
            AirTreatment AirTreatmentType = payload.value;
            _context.AirTreatment.Update(AirTreatmentType);
            _context.SaveChanges();
            return Ok(AirTreatmentType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody] CrudViewModel<AirTreatment> payload)
        {
            AirTreatment AirTreatmentType = _context.AirTreatment
                .Where(x => x.airtreatmentid == (int)payload.key)
                .FirstOrDefault();
            _context.AirTreatment.Remove(AirTreatmentType);
            _context.SaveChanges();
            return Ok(AirTreatmentType);

        }
    }
}