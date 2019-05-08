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

        public Randy(string Name, Random R) : base(Name)
        {
            this.R = R;
        }

        public override string GenerateRoshambo()
        {
            int random = R.Next(0, 3);
            RoshamboValue value = new RoshamboValue(random);
            return value.GenerateValue();
        }
    }
}
