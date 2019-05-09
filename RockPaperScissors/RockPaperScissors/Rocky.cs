using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Rocky : Player
    {
        public Rocky(string Name) : base(Name)
        {            
        }

        public override string GenerateRoshambo()
        {
            // 0 passed to RoshamboValue corresponds to the 0 index in a list containing "rock", "paper", "scissors".
            RoshamboValue value = new RoshamboValue(0); 
            return value.GenerateValue();               
        }
    }
}
