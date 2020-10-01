using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantReservations.Data;
using RestaurantReservations.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantReservations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RestaurantController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("Index")]
        public async Task<ActionResult<IEnumerable<Restaurant>>> Index()
        {
            return await _context.Restaurants.ToListAsync();
        }
        [HttpGet("{id}")]
        [Route("Details/{id}")]
        public async Task<ActionResult<Restaurant>> Details(int id)
        {
            
            var restaurant = await _context.Restaurants.FindAsync(id);

            if (restaurant == null)
            {
                return NotFound();
            }

            return restaurant;
        }

    }
}
