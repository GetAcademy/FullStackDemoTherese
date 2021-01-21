using Microsoft.AspNetCore.Mvc;
using FullStackDemoTherese.Core.ApplicationService;
using FullStackDemoTherese.Core.DomainModel;
using MatchResultViewModel=FullStackDemoTherese.UserInterface.Model.MatchResult;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackDemoTherese.UserInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchResultController : ControllerBase
    {
        private readonly LeagueTableService _leagueTableService;

        public MatchResultController(LeagueTableService leagueTableService)
        {
            _leagueTableService = leagueTableService;
        }

        [HttpPost]
        public void Post(MatchResultViewModel matchResult)
        {
            var result = new MatchResult(
                new Team(matchResult.HomeTeam),
                new Team(matchResult.AwayTeam),
                (byte) matchResult.HomeGoals,
                (byte) matchResult.AwayGoals
                );
            _leagueTableService.AddMatchResult(result);
        }
    }
}
