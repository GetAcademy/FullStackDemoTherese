using System;
using System.Collections.Generic;
using System.Text;

namespace FullStackDemoTherese.Core.DomainModel
{
    public class Team
    {
        public string Name { get; }

        public Team(string name)
        {
            Name = name;
        }
    }
}
