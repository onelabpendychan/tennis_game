using OneBackComboTrainingWeb.Domains;
using OneBackComboTrainingWeb.Enums;
using OneBackComboTrainingWeb.Repos;

namespace OneBackComboTrainingWeb.Controllers;

public class MatchController
{
    private readonly IMatchRepo _matchRepo;

    public MatchController(IMatchRepo matchRepo)
    {
        _matchRepo = matchRepo;
    }

    public string UpdateMatchResult(int matchId, Event @event)
    {
        var match = _matchRepo.GetMatch(matchId);
        match.MatchResult.HomeGoal();
        _matchRepo.UpdateMatchResult(match);
        return match.MatchResult.GetDisplayScore();
    }
}