﻿using BasketballRosterNew.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketballRosterNew.ViewModel
{
    class LeagueViewModel
    {
        public RosterViewModel BriansTeam { get; set; }
        public RosterViewModel JimmysTeam { get; set; }

        public LeagueViewModel()
        {
            Roster briansRoster = new Roster("The Bombers", GetBomberPlayers());
            BriansTeam = new RosterViewModel(briansRoster);

            Roster jimmysRoster = new Roster("The Amazins", GetAmazinsPlayers());
            JimmysTeam = new RosterViewModel(jimmysRoster);
        }

        private IEnumerable<Player> GetAmazinsPlayers()
        {
            List<Player> amazinPlayers = new List<Player>() 
            {
                new Player("Jimmy",42, true),
                new Player("Henry",11, true),
                new Player("Bob",4, true),
                new Player("Lucinda", 18, true),
                new Player("Kim", 16, true),
                new Player("Bertha", 23, false),
                new Player("Ed",21, false),
            };
            return amazinPlayers;
        }

        private IEnumerable<Player> GetBomberPlayers()
        {
            List<Player> bomberPlayers = new List<Player>() 
            {
                new Player("Brian", 31, true),
                new Player("Lloyd", 23, true),
                new Player("Kathleen",6, true),
                new Player("Mike", 0, true),
                new Player("Joe", 42, true),
                new Player("Herb",32, false),
                new Player("Fingers",8, false),
            };

            return bomberPlayers;
        }
    }
}
