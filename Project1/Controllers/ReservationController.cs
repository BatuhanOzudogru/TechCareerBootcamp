using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly TechCareerDbContext _context;

        public ReservationController()
        {
            _context = new TechCareerDbContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
             var reservations = _context.Clients
        .Include(c => c.Rooms) 
        .ToList();

            return Ok(reservations);

        }

        [HttpGet("{id}")]
        public IActionResult Get(int clientId)
        {
            var reservation = _context.Clients
                            .Include(c => c.Rooms) 
                            .FirstOrDefault(c => c.Id == clientId);

            if (reservation == null)
            {
                return NotFound();
            }

            var rooms = reservation.Rooms.ToList();
            return Ok(rooms);
           
        }

     //


    }
}
