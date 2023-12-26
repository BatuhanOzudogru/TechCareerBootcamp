using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
using Task3.Models.ORM;

namespace Task3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly TechCareerDbContext _context;

        public EmployeeController()
        {
            _context = new TechCareerDbContext();
        }

        [HttpGet]
        public IActionResult Get()
        {
            //DBdeki employeeleri getir
            var employees = _context.Employees.ToList();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {

            _context.Employees.Add(employee);
            _context.SaveChanges();

            return StatusCode(201, employee);
        }
        //update
        [HttpPut("{id}")]
        public IActionResult Update(int id, Employee updatedEmployee)
        {
            var existEmployee = _context.Employees.Find(id);

            if (existEmployee == null)
            {
                return NotFound();
            }

            // Dışarıdan aldığımız(input) employeenin propertylerini DB de var olan employeeye eşitliyoruz
            existEmployee.FirstName = updatedEmployee.FirstName;
            existEmployee.LastName = updatedEmployee.LastName;
            existEmployee.Address = updatedEmployee.Address;
            existEmployee.City = updatedEmployee.City;

            
            _context.SaveChanges();

            return Ok(existEmployee);
        }

        //delete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //disaridan gelen id ile employee bul
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);

            //employee yoksa 404 döndür
            if (employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            _context.SaveChanges();

            return Ok(employee);
        }
    }
}
