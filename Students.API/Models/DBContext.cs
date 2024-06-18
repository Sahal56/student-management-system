using Microsoft.EntityFrameworkCore;

namespace Students.API.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        { }
        public DbSet<Student> Students { get; set; } = null!;

    }
}
