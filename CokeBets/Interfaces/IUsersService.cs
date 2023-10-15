using CokeBets.Models;

namespace CokeBets.Interfaces;

public interface IUsersService
{
    Task<IEnumerable<User>> GetAllUsers();
    Task<User> GetUser(int userId);
}