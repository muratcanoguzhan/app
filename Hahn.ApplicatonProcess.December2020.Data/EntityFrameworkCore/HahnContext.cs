using Hahn.ApplicatonProcess.December2020.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Hahn.ApplicatonProcess.December2020.Data.EntityFrameworkCore
{
    public class HahnContext : DbContext
    {
        public HahnContext()
        {
        }

        public HahnContext(DbContextOptions<HahnContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Applicant> Applicants { get; set; }
    }
}
