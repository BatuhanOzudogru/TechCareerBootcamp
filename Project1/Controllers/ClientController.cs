using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly TechCareerDbContext _context;

        public ClientController()
        {
            _context = new TechCareerDbContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var clients = _context.Clients.ToList();
            return Ok(clients);

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var client = _context.Clients.FirstOrDefault(x => x.Id == id);

            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }
        [HttpPost]
        public IActionResult Create(Client client)
        {
            var company = _context.Companies.FirstOrDefault(x => x.Id == client.CompanyId);
            if (company == null)
            {
                return NotFound();
            }
        
            client.Company = company;
            _context.Clients.Add(client);
            _context.SaveChanges();

            return StatusCode(201, client);
        }
        //update
        [HttpPut("{id}")]
        public IActionResult Update(int id, Client updatedClient)
        {
            var existClient = _context.Clients.Find(id);

            if (existClient == null)
            {
                return NotFound();
            }

            // Dışarıdan aldığımız(input) clientin propertylerini DB de var olan cliente eşitliyoruz
            existClient.BirthDate = updatedClient.BirthDate;
            existClient.Surname = updatedClient.Surname;
            existClient.Name = updatedClient.Name;
            existClient.CompanyId = updatedClient.CompanyId;
            existClient.Address = updatedClient.Address;
            existClient.EMail = updatedClient.EMail;


            _context.SaveChanges();

            return Ok(existClient);
        }

        //delete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //disaridan gelen id ile clientı bul
            var client = _context.Clients.FirstOrDefault(x => x.Id == id);

            //employee yoksa 404 döndür
            if (client == null)
            {
                return NotFound();
            }

            _context.Clients.Remove(client);
            _context.SaveChanges();

            return Ok(client);
        }
    }
}
