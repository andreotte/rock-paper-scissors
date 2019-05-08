using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Rocky : Player
    {
        public Rocky()
        {
            name = "Rocky";
        }
        public override string GenerateRoshambo()
        {
            RoshamboValue value = new RoshamboValue(0); // 0 corresponds with "rock" 
            return value.GenerateValue();               
        }
    }
}
