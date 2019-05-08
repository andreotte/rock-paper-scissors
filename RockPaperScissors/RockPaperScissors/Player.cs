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

        public Player()
        {

        }

        public Player(string name)
        {
            this.name = name;
        }

        public abstract string GenerateRoshambo();
    }
}
