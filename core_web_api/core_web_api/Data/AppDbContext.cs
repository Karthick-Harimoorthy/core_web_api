using core_web_api.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace core_web_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {

        }
        public DbSet<Employee> Employee { get; set; }
    }
}
