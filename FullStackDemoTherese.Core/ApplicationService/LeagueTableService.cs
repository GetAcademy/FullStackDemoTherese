using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using FullStackDemoTherese.Core.DomainModel;
using FullStackDemoTherese.Core.DomainService;

namespace FullStackDemoTherese.Core.ApplicationService
{
    public class LeagueTableService
    {
        private readonly IMatchResultRepository _matchResult;

        public LeagueTableService(IMatchResultRepository matchResult)
        {
            _matchResult = matchResult;
        }

        public bool AddMatchResult(MatchResult matchResult)
        {
            return _matchResult.Create(matchResult);
        }

        public LeagueTable GetLeagueTable()
        {
            var matchResults = _matchResult.ReadAll();
            return new LeagueTable(matchResults);
        }
    }
}
