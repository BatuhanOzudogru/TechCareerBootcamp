using Microsoft.EntityFrameworkCore;

namespace Task3.Models.ORM
{
    public class TechCareerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
            optionsBuilder.UseSqlServer("Server=DESKTOP-09CNSBC; Database=TechCareerDb; Trusted_Connection =true");
        }

        public DbSet<Employee> Employees { get; set; }
       
    }
}
