using CokeBets.Models;
using Microsoft.EntityFrameworkCore;

namespace CokeBets.Data;

public class SalesDbContext: DbContext
{
    public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options)
    {
    }
    
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Users> Users { get; set; }
}