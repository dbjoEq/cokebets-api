using Microsoft.EntityFrameworkCore;

namespace CokeBets.Data;

public class CokeBetsDbContext : DbContext
{
    public CokeBetsDbContext(DbContextOptions options) : base(options)
    {
    }
}