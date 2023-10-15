using CokeBets.Interfaces;
using CokeBets.Models;

namespace CokeBets.Services;

public class BetService: IBetService
{
    public BetService()
    {
        
    }

    public async Task<IEnumerable<Bet>> GetBets()
    {
        return null;
    }
}