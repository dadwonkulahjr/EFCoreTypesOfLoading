using Microsoft.EntityFrameworkCore;
using TypesOfLoadingEFCore.Web.Models;

namespace TypesOfLoadingEFCore.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                                        .HasData(SeedEmployeeData.GetEmployees());

            modelBuilder.Entity<Department>()
                                        .HasData(SeedEmployeeData.GetDepartments());
        }
    }
}
