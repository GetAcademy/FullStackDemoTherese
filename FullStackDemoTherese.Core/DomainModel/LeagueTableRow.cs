using System;
using System.Collections.Generic;
using System.Text;

namespace FullStackDemoTherese.Core.DomainModel
{
    public class LeagueTableRow
    {
        public string TeamName { get; }
        public int MatchCount { get; private set; }

        public LeagueTableRow(string teamName)
        {
            TeamName = teamName;
        }

        public void AddMatchResult(MatchResult matchResult)
        {
            MatchCount++;
        }
    }
}
