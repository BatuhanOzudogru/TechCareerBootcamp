using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task4.Models.ORM;

namespace Task4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebUserController : ControllerBase
    {
        private readonly TechCareerDbContext _context;

        public WebUserController()
        {
            _context = new TechCareerDbContext();
        }
        [HttpGet]
        public IActionResult Get()
        {
            
            var webUsers = _context.WebUsers.Include(x=>x.Orders).ToList();
            return Ok(webUsers);
        }
    }
}
