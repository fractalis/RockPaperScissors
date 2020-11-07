using RockPaperScissors.Game;
using RockPaperScissors.Game.Players;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace RockPaperScissors
{
    class Program
    {
        public static (Boolean, BasePlayer) DetermineWinner(BasePlayer player1, BasePlayer player2, int totalRounds, int roundsPlayed)
        {
            if( (float)roundsPlayed/(float)totalRounds > 0.5)
            {
                if(player1.Score > player2.Score)
                {
                    return (true, player1);
                } else if (player1.Score == player2.Score)
                {
                    return (false, null);
                } else
                {
                    return (true, player2);
                }
            } else
            {
                return (false, null);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            HumanPlayer humanPlayer = new HumanPlayer(name);

            int rounds = 3;

            while (true)
            {
                Console.WriteLine("How many rounds do you want to play?");
                rounds = int.Parse(Console.ReadLine());

                if (rounds % 2 == 1)
                    break;
                else
                    Console.WriteLine("Rounds must be an odd number");
            }

            
            ComputerPlayer computerPlayer = new ComputerPlayer("AI Player");

            for (int i = 0; i < rounds; i++)
            {
                GameRound round = new GameRound();
                round.AddPlayer(humanPlayer);
                round.AddPlayer(computerPlayer);
                round.TakeTurn();
                round.ScoreRound();
                (Boolean isWinner, BasePlayer player) = DetermineWinner(humanPlayer, computerPlayer, rounds, i+1);

                if(isWinner)
                {
                    Console.WriteLine(player.Name + " wins the game!");
                    break;
                } else if(i == rounds - 1 && !isWinner)
                {
                    Console.WriteLine("It's a tie game!");
                }
            }
        }
    }
}
