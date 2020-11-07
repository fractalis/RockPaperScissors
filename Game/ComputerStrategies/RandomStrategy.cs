using RockPaperScissors.Game.Moves;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Game.ComputerStrategies
{
    class RandomStrategy : IComputerStrategy
    {
        public IMoveType DetermineMove()
        {
            IMoveType[] moves = new IMoveType[] { new Rock(), new Scissors(), new Paper() };
            Random rnd = new Random();
            var move = moves[rnd.Next(moves.Length)];
            return move;
        }
    }
}
