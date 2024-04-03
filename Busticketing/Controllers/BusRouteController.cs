using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusTicket.Models;
using busticketing.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicketAppDotNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusRouteController : ControllerBase
    {
        private readonly BusTicketDbContext _context;

        public BusRouteController(BusTicketDbContext context)
        {
            _context = context;
        }

        // GET: api/BusRoute
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusRoute>>> GetBusRoutes()
        {
            return await _context.BusRoutes.ToListAsync();
        }

        // GET: api/BusRoute/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BusRoute>> GetBusRoute(int id)
        {
            var busRoute = await _context.BusRoutes.FindAsync(id);

            if (busRoute == null)
            {
                return NotFound();
            }

            return busRoute;
        }

        // POST: api/BusRoute
        [HttpPost]
        public async Task<ActionResult<BusRoute>> PostBusRoute(BusRoute busRoute)
        {
            _context.BusRoutes.Add(busRoute);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBusRoute), new { id = busRoute.RouteId }, busRoute);
        }

        // PUT: api/BusRoute/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusRoute(int id, BusRoute busRoute)
        {
            if (id != busRoute.RouteId)
            {
                return BadRequest();
            }

            _context.Entry(busRoute).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusRouteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/BusRoute/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBusRoute(int id)
        {
            var busRoute = await _context.BusRoutes.FindAsync(id);
            if (busRoute == null)
            {
                return NotFound();
            }

            _context.BusRoutes.Remove(busRoute);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BusRouteExists(int id)
        {
            return _context.BusRoutes.Any(e => e.RouteId == id);
        }
    }
}
