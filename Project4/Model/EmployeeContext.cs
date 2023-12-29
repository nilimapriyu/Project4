using Microsoft.EntityFrameworkCore;

namespace Project4.Model
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {

        }
        public DbSet<TblEmployee> TblEmployee { get; set; }

        public DbSet<TblDesignation> TblDesignation { get; set; }
    }
}
