using CollegeFootballRisk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeFootballRisk
{
    public class Risk
    {
        internal DateTimeOffset LastUpdated { get; set; }
        internal const uint RefreshTimeInSeconds = 60 * 10;
        internal const string BaseUrl = "https://collegefootballrisk.com/api";

        public Risk(bool populateAll = true)
        {
            if (populateAll)
            {
                RefreshAllAsync()/*.Wait()*/;
            }
        }

        private /*async Task*/void RefreshAllAsync()
        {
            LastUpdated = DateTimeOffset.Now;
        }

        public IEnumerable<Player> GetPlayers(string? team = null)
        {
            CheckForRefresh();
            if (team == null)
            {
                //return _playerCache!;
            }
            else
            {
                //return _playerCache.Where(p => team.Equals(p.Team.Name, StringComparison.InvariantCultureIgnoreCase));
            }
            return Enumerable.Empty<Player>();
        }

        public IEnumerable<Team> GetTeams()
        {
            CheckForRefresh();
            //return _teamCache!;
            return Enumerable.Empty<Team>();
        }

        private void CheckForRefresh()
        {
            if (DateTimeOffset.Now - LastUpdated > TimeSpan.FromSeconds(RefreshTimeInSeconds)/* ||
                _playerCache == null || _teamCache == null*/)
            {
                RefreshAllAsync()/*.Wait()*/;
            }
        }
    }
}
