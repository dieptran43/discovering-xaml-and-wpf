using System;
using System.Collections.Generic;
using System.Text;

namespace BasketballRosterNew.Model
{
    class Roster
    {
        public string TeamName { get; set; }

        private readonly List<Player> _players = new List<Player>();
        public IEnumerable<Player> Players
        {
            get { return new List<Player>(_players); }
        }

        public Roster(string teamName,IEnumerable<Player> players)
        {
            TeamName = teamName;
            _players.AddRange(players);
        }
    }
}
