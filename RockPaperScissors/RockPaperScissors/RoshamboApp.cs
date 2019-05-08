using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RoshamboApp
    {
        public FreeWillPlayer player1;

        public RoshamboApp()
        {
            FreeWillPlayer player = new FreeWillPlayer();
            player1 = player;
            NewGame();
        }

        public void NewGame()
        {
            //player1.SetName();
            DeterminePlayer2();
        }

        public void DeterminePlayer2()
        {
            Console.WriteLine($"OK, {player1.name}. Who do you want to play against?");
            Console.WriteLine("1: Randy");
            Console.WriteLine("2: Rocky");
            Console.WriteLine("3: Another human");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "randy" || input == "1")
            {
                Randy randall = new Randy();
                FindWinner(player1, randall);
            }

            else if (input == "rocky" || input == "2")
            {
                Rocky rocky = new Rocky();
                FindWinner(player1, rocky);
            }

            else if (input == "another human" || input == "3")
            {
                Console.WriteLine("OK, player 2.");
                FreeWillPlayer secondPlayer = new FreeWillPlayer();
                FindWinner(player1, secondPlayer);
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                DeterminePlayer2();
            }
        }

        public void PrintInfo(Player isWinner, string player1Throw, string player2Throw)
        {
            if (player1Throw == player2Throw)
            {
                Console.WriteLine($"{player1.name} threw {player1Throw}. secondPlayer threw {player2Throw}.");
                Console.WriteLine("Its a tie!");
            }
            else
            {
                Console.WriteLine($"{player1.name} threw {player1Throw}. secondPlayer threw {player2Throw}."); // need to pull second player out of here
                Console.WriteLine($"{isWinner.name} is the winner!");
            }
        }

        public void FindWinner(Player one, Player two)
        {
            Player isWinner = null;

            string player1Throw = one.GenerateRoshambo();
            string player2Throw = two.GenerateRoshambo();

            if (player1Throw == player2Throw)
            {
                PrintInfo(isWinner, player1Throw, player2Throw);
            }
            else
            {
                if (player1Throw == "rock")
                {
                    if(player2Throw == "scissors")
                    {
                        isWinner = one;
                        PrintInfo(isWinner, player1Throw, player2Throw);
                    }
                    else
                    {
                        isWinner = two;
                        PrintInfo(isWinner, player1Throw, player2Throw);
                    }
                } 
                else if (player1Throw == "paper")
                {
                    if(player2Throw == "rock")
                    {
                        isWinner = one;
                        PrintInfo(isWinner, player1Throw, player2Throw);
                    }
                    else
                    {
                        isWinner = two;
                        PrintInfo(isWinner, player1Throw, player2Throw);
                    }
                }
                else if (player1Throw == "scissors")
                {
                    if(player2Throw == "paper")
                    {
                        isWinner = one;
                        PrintInfo(isWinner, player1Throw, player2Throw);
                    }
                    else
                    {
                        isWinner = two;
                        PrintInfo(isWinner, player1Throw, player2Throw);
                    }
                }
            }
        }
    }
}
