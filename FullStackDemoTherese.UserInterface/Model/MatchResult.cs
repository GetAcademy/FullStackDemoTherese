using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStackDemoTherese.Core.DomainModel;

namespace FullStackDemoTherese.UserInterface.Model
{
    public class MatchResult
    {
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
    }
}
