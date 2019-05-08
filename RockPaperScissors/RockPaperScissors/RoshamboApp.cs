using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RoshamboApp
    {
        Random rando = new Random();

        public FreeWillPlayer player1;
        public Player player2;
        public int Player1Wins { get; set; }
        public int Player2Wins { get; set; }

        public RoshamboApp()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            player1 = new FreeWillPlayer(userName);
            NewGame();
        }

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

        public void PrintInfo(Player isWinner, string player1Throw, string player2Throw)
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
                        Player1Wins += 1;
                        PrintInfo(isWinner, player1Throw, player2Throw);
                    }
                    else
                    {
                        isWinner = two;
                        Player2Wins += 1;
                        PrintInfo(isWinner, player1Throw, player2Throw);
                    }
                } 
                else if (player1Throw == "paper")
                {
                    if(player2Throw == "rock")
                    {
                        isWinner = one;
                        Player1Wins += 1;
                        PrintInfo(isWinner, player1Throw, player2Throw);
                    }
                    else
                    {
                        isWinner = two;
                        Player2Wins += 1;
                        PrintInfo(isWinner, player1Throw, player2Throw);
                    }
                }
                else if (player1Throw == "scissors")
                {
                    if(player2Throw == "paper")
                    {
                        isWinner = one;
                        Player1Wins += 1;
                        PrintInfo(isWinner, player1Throw, player2Throw);
                    }
                    else
                    {
                        isWinner = two;
                        Player2Wins += 1;
                        PrintInfo(isWinner, player1Throw, player2Throw);
                    }
                }
            }
        }
    }
}
