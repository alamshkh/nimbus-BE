using Microsoft.EntityFrameworkCore;
using NimbusBank.Backend.Models;

namespace NimbusBank.Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<LoanApplication> LoanApplications { get; set; }
    }
}