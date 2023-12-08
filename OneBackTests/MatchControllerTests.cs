using Microsoft.Extensions.FileSystemGlobbing;
using NSubstitute;
using OneBackComboTrainingWeb.Controllers;
using OneBackComboTrainingWeb.Domains;
using OneBackComboTrainingWeb.Repos;
using Event = OneBackComboTrainingWeb.Enums.Event;

namespace OneBackTests;

public class MatchControllerTests
{

    private MatchController _matchController;
    private IMatchRepo? _matchRepo;

    [SetUp]
    public void Setup()
    {
        _matchRepo = Substitute.For<IMatchRepo>();
        _matchController = new MatchController(_matchRepo);
    }

    [Test]
    public void home_goal()
    {
        int matchId = 91;
        _matchRepo.GetMatch(91).Returns(new Match() { Id = 91, MatchResult = new MatchResult("") });
        var displayScore = _matchController.UpdateMatchResult(matchId, Event.HomeGoal);
        Assert.That("1:0 (First Half)", Is.EqualTo(displayScore));
        _matchRepo.Received(1).UpdateMatchResult(Arg.Is<Match>(match => match.MatchResult.GetResult() == "H"));
    }

}