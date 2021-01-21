using System;
using System.Collections.Generic;
using System.Text;
using FullStackDemoTherese.Core.DomainModel;
using FullStackDemoTherese.Core.DomainService;

namespace FullStackDemoTherese.DataAccess
{
    public class MatchResultInMemoryRepository : IMatchResultRepository
    {
        private readonly List<MatchResult> _list;

        public MatchResultInMemoryRepository()
        {
            _list = new List<MatchResult>();
        }

        public bool Create(MatchResult matchResult)
        {
            _list.Add(matchResult);
            return true;
        }

        public IEnumerable<MatchResult> ReadAll()
        {
            return _list;
        }
    }
}
