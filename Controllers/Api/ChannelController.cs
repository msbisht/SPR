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
    [Route("api/Channel")]
    public class ChannelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChannelController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomerType
        [HttpGet]
        public async Task<IActionResult> GetChannel()
        {
            List<Channel> Items = await _context.Channel.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }



        [HttpPost("[action]")]
        public IActionResult Insert([FromBody] CrudViewModel<Channel> payload)
        {
            Channel channelType = payload.value;
            _context.Channel.Add(channelType);
            _context.SaveChanges();
            return Ok(channelType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody] CrudViewModel<Channel> payload)
        {
            Channel channelType = payload.value;
            _context.Channel.Update(channelType);
            _context.SaveChanges();
            return Ok(channelType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody] CrudViewModel<Channel> payload)
        {
            Channel channel = _context.Channel
                .Where(x => x.channelid == (int)payload.key)
                .FirstOrDefault();
            _context.Channel.Remove(channel);
            _context.SaveChanges();
            return Ok(channel);

        }
    }
}
