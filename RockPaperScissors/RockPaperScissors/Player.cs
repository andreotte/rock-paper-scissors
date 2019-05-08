using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public abstract class Player
    {
        public string name;
        public string Name { get; set; }

        public Player(string Name)
        {
            this.Name = Name;
        }

        public abstract string GenerateRoshambo();
    }
}
