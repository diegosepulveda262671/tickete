using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ticket.API.Data;

using Ticket.Shared.Entities;

namespace Ticket.API.Controllers
{
    [ApiController]
    [Route("/api/ticket")]
    public class TicketsController : ControllerBase
    {
        private readonly DataContext _context;

        public TicketsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var country = await _context.Ticketes
                .FirstOrDefaultAsync(x => x.Id == id);
            if (country == null)
            {
                return NotFound();
            }

            return Ok(country);
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(Tickete country)
        {
            try
            {
                _context.Add(country);
                await _context.SaveChangesAsync();
                return Ok(country);
            }
            catch (DbUpdateException dbUpdateException)
            {
              

                return BadRequest(dbUpdateException.Message);
            }
            catch(Exception exception) 
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(Tickete country)
        {
            try
            {
                _context.Update(country);
                await _context.SaveChangesAsync();
                return Ok(country);
            }
            catch (DbUpdateException dbUpdateException)
            {
                

                return BadRequest(dbUpdateException.Message);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        
    }
}
