using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly TechCareerDbContext _context;

        public RoomController()
        {
            _context = new TechCareerDbContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var rooms = _context.Rooms.ToList();
            return Ok(rooms);

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var room = _context.Rooms.FirstOrDefault(x => x.Id == id);

            if (room == null)
            {
                return NotFound();
            }

            return Ok(room);
        }
        [HttpPost]
        public IActionResult Create(Room room)
        {

            _context.Rooms.Add(room);
            _context.SaveChanges();

            return StatusCode(201, room);
        }
        //update
        [HttpPut("{id}")]
        public IActionResult Update(int id, Room updatedRoom)
        {
            var existRoom = _context.Rooms.Find(id);

            if (existRoom == null)
            {
                return NotFound();
            }

            // Dışarıdan aldığımız(input) roomun propertylerini DB de var olan room ile eşitliyoruz
           existRoom.Name= updatedRoom.Name;


            _context.SaveChanges();

            return Ok(existRoom);
        }

        //delete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //disaridan gelen id ile roomu bul
            var room = _context.Rooms.FirstOrDefault(x => x.Id == id);

            //room yoksa 404 döndür
            if (room == null)
            {
                return NotFound();
            }

            _context.Rooms.Remove(room);
            _context.SaveChanges();

            return Ok(room);
        }
    }
}
