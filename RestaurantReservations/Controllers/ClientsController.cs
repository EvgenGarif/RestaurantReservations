using Microsoft.AspNetCore.Mvc;
using RestaurantReservations.Data;
using RestaurantReservations.Model;
using System.Threading.Tasks;

namespace RestaurantReservations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClientsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<Client>> PostClient([FromBody] Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClient", new { id = client.Id }, client);
        }
    }
}
