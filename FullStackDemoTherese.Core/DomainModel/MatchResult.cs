using System;
using System.Collections.Generic;
using System.Text;

namespace FullStackDemoTherese.Core.DomainModel
{
    public class MatchResult
    {
        public Team HomeTeam { get; }
        public Team AwayTeam { get; }
        public byte HomeGoals { get; }
        public byte AwayGoals { get; }

        public MatchResult(Team homeTeam, Team awayTeam, byte homeGoals, byte awayGoals)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeGoals = homeGoals;
            AwayGoals = awayGoals;
        }
    }
}
