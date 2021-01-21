using System;
using System.Collections.Generic;
using System.Text;
using FullStackDemoTherese.Core.DomainModel;

namespace FullStackDemoTherese.Core.DomainService
{
    public interface IMatchResultRepository
    {
        bool Create(MatchResult matchResult);
        IEnumerable<MatchResult> ReadAll();
    }
}
