using CokeBets.Data;
using CokeBets.Interfaces;
using CokeBets.Models;

namespace CokeBets.Services;

public class UsersService : IUsersService
{
    private readonly CokeBetsDbContext _dbContext;

    public UsersService(CokeBetsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<User>> GetAllUsers()
    {
        List<User> users = _dbContext.User.ToList();
        
        return users;
    }

    public async Task<User> GetUser(int userId)
    {
        List<User> users = _dbContext.User.ToList();
        var user = users.Find(user => user.UserId == userId);
        return user;
    } 
}