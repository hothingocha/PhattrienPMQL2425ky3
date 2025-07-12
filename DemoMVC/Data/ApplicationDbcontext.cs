using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<DemoMVC.Models.HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = default!;
        public DbSet<DemoMVC.Models.DaiLy> DaiLy { get; set; } = default!;
    }
}