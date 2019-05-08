using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Randy : Player
    {
        public Randy()
        {
            name = "Randy";
        }
        public override string GenerateRoshambo()
        {
            Random rand = new Random();
            int random = rand.Next(0, 3);
            RoshamboValue value = new RoshamboValue(random);
            return value.GenerateValue();
        }
    }
}
