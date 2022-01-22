using Microsoft.EntityFrameworkCore;

namespace SqlConnect.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Studentclass1> Studentclass1s { get; set; }
        
    }
}
