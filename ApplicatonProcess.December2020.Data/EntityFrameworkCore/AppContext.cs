using ApplicatonProcess.December2020.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicatonProcess.December2020.Data.EntityFrameworkCore
{
    public class AppContext : DbContext
    {
        public AppContext()
        {
        }

        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Applicant> Applicants { get; set; }
    }
}
