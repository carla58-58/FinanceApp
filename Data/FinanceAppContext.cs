namespace FinanceApp.Data
{
    using Microsoft.EntityFrameworkCore;
    using FinanceApp.Models;

    public class FinanceAppContext : DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options)
            : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
        
    }
}