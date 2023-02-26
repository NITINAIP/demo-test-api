namespace demo_test_api.Context;

using demo_test_api.Model;
using Microsoft.EntityFrameworkCore;

public class PgContext : DbContext
{
    public PgContext(DbContextOptions<PgContext> options) : base(options)
    {

    }
    public DbSet<Fibonacci> Fibonacci { get; set; }

}