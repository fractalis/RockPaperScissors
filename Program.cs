using RockPaperScissors.Game;
using RockPaperScissors.Game.Players;
using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            HumanPlayer humanPlayer = new HumanPlayer(name);
            ComputerPlayer computerPlayer = new ComputerPlayer("AI Player");

            GameRound round = new GameRound();
            round.AddPlayer(humanPlayer);
            round.AddPlayer(computerPlayer);
            round.TakeTurn();
            round.ScoreRound();
        }
    }
}
