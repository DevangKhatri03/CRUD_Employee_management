using CRUD_Employee_management.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Employee_management.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
