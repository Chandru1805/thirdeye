using Microsoft.EntityFrameworkCore;
using thirdeyeweb.Models.Domain;

namespace thirdeyeweb.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
