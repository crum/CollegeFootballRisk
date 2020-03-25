using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeFootballRisk.Models
{
    public class Team
    {
        public long Id { get; set; } = default;
        public string Name { get; set; } = null!;
        public string Logo { get; set; } = null!;
        public TeamColors Colors { get; set; } = null!;
    }
}
