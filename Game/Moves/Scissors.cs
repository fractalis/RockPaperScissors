using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Game.Moves
{
    class Scissors : IMoveType
    {
        public string Name { get; } = "Scissors";

        public GameResults.ResultsType CanBeat(IMoveType moveType)
        {
            switch(moveType)
            {
                case Rock r:
                    return GameResults.ResultsType.Lose;
                case Scissors s:
                    return GameResults.ResultsType.Tie;
                case Paper p:
                    return GameResults.ResultsType.Win;
                default:
                    return GameResults.ResultsType.Tie;
            }
        }
    }
}
