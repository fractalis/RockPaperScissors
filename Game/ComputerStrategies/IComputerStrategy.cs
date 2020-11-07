using RockPaperScissors.Game.Moves;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Game.ComputerStrategies
{
    interface IComputerStrategy
    {
        public IMoveType DetermineMove();
    }
}
