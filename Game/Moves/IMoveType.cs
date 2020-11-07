using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Game.Moves
{
    interface IMoveType
    {
        GameResults.ResultsType CanBeat(IMoveType moveType);
    }
}
