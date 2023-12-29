using Microsoft.EntityFrameworkCore;
using Task4.Controllers;

namespace Task4.Models.ORM
{
    public class TechCareerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
            optionsBuilder.UseSqlServer("Server=DESKTOP-09CNSBC; Database=TechCareerTask3Db; Trusted_Connection =true");
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<WebUser> WebUsers { get; set; }

    }
}
