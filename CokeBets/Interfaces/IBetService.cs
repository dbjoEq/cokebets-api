using CokeBets.Models;

namespace CokeBets.Interfaces;

public interface IBetService
{
    Task<IEnumerable<Bet>> GetAllBets();
    Task<IEnumerable<Bet>> GetAllActiveBets();
    Task<IEnumerable<Bet>> GetAllCompletedBets();
    Task<Bet> GetBet(int betId);
    Task<IEnumerable<Bet>> GetAllBetsForUser(int userId);
    Task<IEnumerable<Bet>> GetAllActiveBetsForUser(int userId);
    Task<IEnumerable<Bet>> GetAllCompletedBetsForUser(int userId);
}