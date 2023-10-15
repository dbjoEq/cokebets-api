using CokeBets.Models;
using Microsoft.EntityFrameworkCore;

namespace CokeBets.Data;

public class CokeBetsDbContext : DbContext
{
    public CokeBetsDbContext(DbContextOptions<CokeBetsDbContext> options) : base(options)
    {
   
    }
    
    public DbSet<User> User { get; set; }
    public DbSet<Bet> Bet { get; set; }
}