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
                    .Include(c => c.Company)
                    .ToList();

            return Ok(reservations);

        }

      

   


    }
}
