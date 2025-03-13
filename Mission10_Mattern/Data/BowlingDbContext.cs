using Microsoft.EntityFrameworkCore;

namespace Mission10_Mattern.Data;

public class BowlingDbContext : DbContext
{
    public BowlingDbContext(DbContextOptions<BowlingDbContext> options) : base(options)
    {
        
    }
    public DbSet<BowlingLeague> Bowlings { get; set; }
}
