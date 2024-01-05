using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly TechCareerDbContext _context;

        public CompanyController()
        {
            _context = new TechCareerDbContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var companies = _context.Companies.ToList();
            return Ok(companies);

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var company = _context.Companies.FirstOrDefault(x => x.Id == id);

            if (company == null)
            {
                return NotFound();
            }

            return Ok(company);
        }
        [HttpPost]
        public IActionResult Create(Company company)
        {

            _context.Companies.Add(company);
            _context.SaveChanges();

            return StatusCode(201, company);
        }
        //update
        [HttpPut("{id}")]
        public IActionResult Update(int id, Company updatedCompany)
        {
            var existCompany = _context.Companies.Find(id);

            if (existCompany == null)
            {
                return NotFound();
            }

            // Dışarıdan aldığımız(input) company propertylerini DB de var olan company eşitliyoruz
            existCompany.Name = updatedCompany.Name;
            existCompany.Address = updatedCompany.Address;


            _context.SaveChanges();

            return Ok(existCompany);
        }

        //delete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //disaridan gelen id ile companyi bul
            var company = _context.Companies.FirstOrDefault(x => x.Id == id);

            //company yoksa 404 döndür
            if (company == null)
            {
                return NotFound();
            }

            _context.Companies.Remove(company);
            _context.SaveChanges();

            return Ok(company);
        }
    }
}
