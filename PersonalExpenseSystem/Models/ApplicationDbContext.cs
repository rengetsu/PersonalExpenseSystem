using Microsoft.EntityFrameworkCore;
using PersonalExpenseSystem.Models;

namespace PersonalExpenseSystem.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Transaction> Categories { get; set; }
        public DbSet<PersonalExpenseSystem.Models.Category>? Category { get; set; }
    }
}
