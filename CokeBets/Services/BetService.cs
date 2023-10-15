using CokeBets.Data;
using CokeBets.Interfaces;
using CokeBets.Models;

namespace CokeBets.Services;

public class BetService : IBetService
{
    private readonly CokeBetsDbContext _dbContext;

    public BetService(CokeBetsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Bet>> GetAllBets()
    {
        var bets = _dbContext.Bet.ToList();
        return bets;
    }

    public async Task<IEnumerable<Bet>> GetAllBetsForUser(int userId)
    {
        var bets = _dbContext.Bet.ToList().FindAll(bet => bet.PlayerOne == userId || bet.PlayerTwo == userId);
        return bets;
    }

    public async Task<IEnumerable<Bet>> GetAllActiveBetsForUser(int userId)
    {
        var bets = _dbContext.Bet.ToList().FindAll(bet => bet.PlayerOne == userId || bet.PlayerTwo == userId)
            .FindAll(bet => bet.Status == "Active");
        return bets;
    }
    
    public async Task<IEnumerable<Bet>> GetAllCompletedBetsForUser(int userId)
    {
        var bets = _dbContext.Bet.ToList().FindAll(bet => bet.PlayerOne == userId || bet.PlayerTwo == userId)
            .FindAll(bet => bet.Status == "Completed");
        return bets;
    }

    public async Task<IEnumerable<Bet>> GetAllActiveBets()
    {
        var bets = _dbContext.Bet.ToList().FindAll(bet => bet.Status == "Active");
        return bets;
    }

    public async Task<IEnumerable<Bet>> GetAllCompletedBets()
    {
        var bets = _dbContext.Bet.ToList().FindAll(bet => bet.Status == "Completed");
        return bets;
    }

    public async Task<Bet> GetBet(int betId)
    {
        var bets = _dbContext.Bet.ToList();
        var bet = bets.Find(bet => bet.BetId == betId);
        return bet;
    }
}