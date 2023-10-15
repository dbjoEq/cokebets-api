using CokeBets.Models;

namespace CokeBets.Interfaces;

public interface IUsersService
{
    Task<IEnumerable<Users>> GetAllUsers();
}