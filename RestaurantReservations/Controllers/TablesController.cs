using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantReservations.Data;
using RestaurantReservations.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TablesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("{id}")]
        [Route("DetailsTable/{id}")]
        public async Task<ActionResult<IEnumerable<Table>>> GetTableResturantId(int id)
        {
            var table = await _context.Tables.Where(r => r.RestaurantId == id).ToListAsync();

            if (table == null)
            {
                return NotFound();
            }

            return table;
        }
        [HttpGet("{id}")]
        [Route("DetailsClient/{id}")]
        public async Task<ActionResult<IEnumerable<Client>>> GetTableClient(int id)
        {
            var table = await _context.Clients.Include(t => t.Table.Clients).Where(r => r.Table.RestaurantId == id).ToListAsync();

            if (table == null)
            {
                return NotFound();
            }

            return table;
        }
    }
}
