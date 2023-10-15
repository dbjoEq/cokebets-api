using CokeBets.Models;

namespace CokeBets.Interfaces;

public interface IBetService
{
    Task<IEnumerable<Bet>> GetBets();
}