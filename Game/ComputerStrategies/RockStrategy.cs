using RockPaperScissors.Game.Moves;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Game.ComputerStrategies
{
    class RockStrategy : IComputerStrategy
    {
        public IMoveType DetermineMove()
        {
            return new Rock();
        }
    }
}
