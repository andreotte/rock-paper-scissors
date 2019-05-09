using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Randy : Player
    {
        public Random R { get; set; }

        // Random object created in and passed from RoshamboApp 
        public Randy(string Name, Random R) : base(Name)
        {
            this.R = R;
        }

        public override string GenerateRoshambo()
        {
            int random = R.Next(0, 3);
            // random passed to RoshamboValue corresponds to an index in a list containing "rock", "paper", "scissors".
            RoshamboValue value = new RoshamboValue(random);
            return value.GenerateValue();
        }
    }
}
