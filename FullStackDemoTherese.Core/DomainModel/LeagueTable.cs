using System;
using System.Collections.Generic;
using System.Text;

namespace FullStackDemoTherese.Core.DomainModel
{
    public class LeagueTable
    {
        public IEnumerable<LeagueTableRow> Rows => _rows.Values;
        private readonly Dictionary<string, LeagueTableRow> _rows;

        public LeagueTable(IEnumerable<MatchResult> matchResults)
        {
            _rows = new Dictionary<string, LeagueTableRow>();
            foreach (var matchResult in matchResults)
            {
                var homeTeamRow = GetOrCreateLeagueTableRow(matchResult.HomeTeam.Name);
                homeTeamRow.AddMatchResult(matchResult);
                var awayTeamRow = GetOrCreateLeagueTableRow(matchResult.AwayTeam.Name);
                awayTeamRow.AddMatchResult(matchResult);
            }
        }

        private LeagueTableRow GetOrCreateLeagueTableRow(string matchResultHomeTeam)
        {
            if (!_rows.ContainsKey(matchResultHomeTeam))
            {
                _rows.Add(matchResultHomeTeam, new LeagueTableRow(matchResultHomeTeam));
            }

            var leagueTableRow = _rows[matchResultHomeTeam];
            return leagueTableRow;
        }
    }
}
