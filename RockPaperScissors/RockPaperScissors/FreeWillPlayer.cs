using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class FreeWillPlayer : Player
    {
        public FreeWillPlayer(string Name) : base(Name)
        {
        }

        // Ask the FreeWillUsers to throw rock, paper, or scissors.    
        public override string GenerateRoshambo()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name} - throw rock, paper, or scissors?");
            Console.Write(": ");
            string input = Console.ReadLine().Trim().ToLower();

            // Integers passed to RoshamboValue correspond to indecies in a list containing "rock", "paper", "scissors".
            if(input == "rock")
            {
                RoshamboValue value = new RoshamboValue(0);
                return value.GenerateValue();
            }
            else if(input == "paper")
            {
                RoshamboValue value = new RoshamboValue(1);
                return value.GenerateValue();
            }
            else if (input == "scissors")
            {
                RoshamboValue value = new RoshamboValue(2);
                return value.GenerateValue();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                return GenerateRoshambo();
            }
        }
    }
}
