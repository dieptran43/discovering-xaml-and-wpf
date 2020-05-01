using System;
using System.Collections.Generic;
using System.Text;

namespace BasketballRosterNew.ViewModel
{
    class PlayerViewModel
    {
        public string Name { get; private set; }
        public int Number { get; private set; }

        public PlayerViewModel(string name,int number)
        {
            Name = name;
            Number = number;
        }
    }
}
