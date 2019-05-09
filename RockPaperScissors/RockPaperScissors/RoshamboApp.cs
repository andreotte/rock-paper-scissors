using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RoshamboApp
    {
        // Random object to pass to Player Randy and reuse if playing multiple times. 
        Random rando = new Random();

        public FreeWillPlayer player1;  // The user player
        public Player player2;  // Player2 can be Rocky, Randy, or another human that will choose an RPS value
        public int Player1Wins { get; set; }  // Holds the user wins 
        public int Player2Wins { get; set; }  // Holds the opponent wins. *All opponent wins are added together reguardless of oppenent type.  

        public RoshamboApp()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            player1 = new FreeWillPlayer(userName);
            NewGame();
        }

        // Method to generate a new game inside of the same session. User player will remain the same,
        // but user will be prompted to choose an opponent each time. 
        public void NewGame()
        {
            bool run = true;
            do
            {
                Console.WriteLine();
                DeterminePlayer2();
                Console.WriteLine();
                Console.Write("Play again? (y/n): ");
                string playAgain = Console.ReadLine().ToLower().Trim();
                Console.Clear();

                if (playAgain == "n" || playAgain == "no")
                {
                    run = false; 
                }
            } while (run);
        }

        // Method for the user player to decide who they want to play against. 
        public void DeterminePlayer2()
        {
            Console.WriteLine($"OK, {player1.Name}. Who do you want to play against?");
            Console.WriteLine("1: Randy");
            Console.WriteLine("2: Rocky");
            Console.WriteLine("3: Another human");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "randy" || input == "1")
            {
                player2 = new Randy("Randy", rando);
                FindWinner(player1, player2);
            }

            else if (input == "rocky" || input == "2")
            {
                player2 = new Rocky("The Rock");
                FindWinner(player1, player2);
            }

            else if (input == "another human" || input == "3")
            {
                Console.WriteLine();
                Console.Write("OK player 2. Enter your name: ");
                string inputName = Console.ReadLine();
                player2 = new FreeWillPlayer(inputName);
                FindWinner(player1, player2);
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                DeterminePlayer2();
            }
        }

        public void PrintResult(Player isWinner, string player1Throw, string player2Throw)
        {
            if (player1Throw == player2Throw)
            {
                Console.WriteLine();
                Console.WriteLine($"{player1.Name} threw . {player2.Name} threw {player2Throw}.");
                Console.WriteLine("Its a tie!");
                Console.WriteLine($"{player1.Name}'s wins: {Player1Wins}, Opponent wins: {Player2Wins}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"{player1.Name} threw {player1Throw}. {player2.Name} threw {player2Throw}."); // need to pull second player out of here
                Console.WriteLine($"{isWinner.Name} is the winner!");
                Console.WriteLine($"{player1.Name}'s wins: {Player1Wins}, Opponent wins: {Player2Wins}");
            }
        }

        // Generate RPS values for each player and determine winner. 
        public void FindWinner(Player one, Player two)
        {
            Player isWinner = null;

            // Generate RPS values
            string player1Throw = one.GenerateRoshambo();
            string player2Throw = two.GenerateRoshambo();

            if (player1Throw == player2Throw)
            {
                PrintResult(isWinner, player1Throw, player2Throw);
            }
            else
            {
                if (player1Throw == "rock")
                {
                    if(player2Throw == "scissors")
                    {
                        isWinner = one;
                        Player1Wins += 1;
                        PrintResult(isWinner, player1Throw, player2Throw);
                    }
                    else
                    {
                        isWinner = two;
                        Player2Wins += 1;
                        PrintResult(isWinner, player1Throw, player2Throw);
                    }
                } 
                else if (player1Throw == "paper")
                {
                    if(player2Throw == "rock")
                    {
                        isWinner = one;
                        Player1Wins += 1;
                        PrintResult(isWinner, player1Throw, player2Throw);
                    }
                    else
                    {
                        isWinner = two;
                        Player2Wins += 1;
                        PrintResult(isWinner, player1Throw, player2Throw);
                    }
                }
                else if (player1Throw == "scissors")
                {
                    if(player2Throw == "paper")
                    {
                        isWinner = one;
                        Player1Wins += 1;
                        PrintResult(isWinner, player1Throw, player2Throw);
                    }
                    else
                    {
                        isWinner = two;
                        Player2Wins += 1;
                        PrintResult(isWinner, player1Throw, player2Throw);
                    }
                }
            }
        }
    }
}
