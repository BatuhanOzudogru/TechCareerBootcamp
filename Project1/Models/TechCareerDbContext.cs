using Microsoft.EntityFrameworkCore;

namespace Project1.Models
{
    public class TechCareerDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-09CNSBC; Database=Project1Db; Trusted_Connection =true");
        }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Company> Companies { get; set; }

        

    }
}
