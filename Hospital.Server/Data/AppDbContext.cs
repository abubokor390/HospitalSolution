using Hospital.Shared;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Server.Data
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
