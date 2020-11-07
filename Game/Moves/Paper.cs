using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Game.Moves
{
    class Paper : IMoveType
    {
        public string Name { get; } = "Paper";

        public GameResults.ResultsType CanBeat(IMoveType moveType)
        {
            switch(moveType)
            {
                case Rock r:
                    return GameResults.ResultsType.Win;
                case Scissors s:
                    return GameResults.ResultsType.Lose;
                case Paper p:
                    return GameResults.ResultsType.Tie;
                default:
                    return GameResults.ResultsType.Tie;
            }
        }
    }
}
