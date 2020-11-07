using RockPaperScissors.Game.Moves;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Game
{
    class GameRound
    {
        public List<BasePlayer> Players;

        public GameRound()
        {
            Players = new List<BasePlayer>();
        }

        public void AddPlayer(BasePlayer player)
        {
            Players.Add(player);
        }

        public void TakeTurn()
        {
            foreach(var player in Players)
            {
                player.GetMove();
            }
        }


        public void ScoreRound()
        {
            for(int i = 0; i < Players.Count-1; i++)
            {
                BasePlayer player1 = Players[i];
                BasePlayer player2 = Players[i + 1];

                if(player1.Move.CanBeat(player2.Move) == GameResults.ResultsType.Win)
                {
                    Console.WriteLine(player1.Name + " beats " + player2.Name);
                    player1.IncrementScore();
                } else if(player1.Move.CanBeat(player2.Move) == GameResults.ResultsType.Tie)
                {
                    Console.WriteLine("Its a tie!");
                } else
                {
                    Console.WriteLine(player2.Name + " beats " + player1.Name);
                    player2.IncrementScore();
                }
            }
        }
    }
}
