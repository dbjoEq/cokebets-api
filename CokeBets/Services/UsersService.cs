using CokeBets.Data;
using CokeBets.Interfaces;
using CokeBets.Models;

namespace CokeBets.Services;

public class UsersService : IUsersService
{
    private readonly SalesDbContext _dbContext;

    public UsersService(SalesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Users>> GetAllUsers()
    {
        List<Users> users = _dbContext.Users.ToList();
        
        return users;
    }
}