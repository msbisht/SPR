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
    [Route("api/Competition")]
    public class CompetitionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompetitionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomerType
        [HttpGet]
        public async Task<IActionResult> GetFacility()
        {
            List<Competition> Items = await _context.Competition.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] CrudViewModel<Competition> payload)
        {
            Competition CompetitionType = payload.value;
            _context.Competition.Add(CompetitionType);
            _context.SaveChanges();
            return Ok(CompetitionType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody] CrudViewModel<Competition> payload)
        {
            Competition CompetitionType = payload.value;
            _context.Competition.Update(CompetitionType);
            _context.SaveChanges();
            return Ok(CompetitionType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody] CrudViewModel<Competition> payload)
        {
            Competition CompetitionType = _context.Competition
                .Where(x => x.competitionid == (int)payload.key)
                .FirstOrDefault();
            _context.Competition.Remove(CompetitionType);
            _context.SaveChanges();
            return Ok(CompetitionType);

        }
    }
}

