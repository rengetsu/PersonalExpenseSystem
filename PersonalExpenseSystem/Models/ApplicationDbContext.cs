using Microsoft.EntityFrameworkCore;

namespace PersonalExpenseSystem.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Transaction> Categories { get; set; }
    }
}
