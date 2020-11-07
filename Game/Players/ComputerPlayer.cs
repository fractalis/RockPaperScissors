using RockPaperScissors.Game.ComputerStrategies;
using RockPaperScissors.Game.Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissors.Game.Players
{
    class ComputerPlayer : BasePlayer
    {
        public ComputerPlayer(string name) : base(name)
        {
            IComputerStrategy[] strategies = new IComputerStrategy[] { new RockStrategy() };
            Random rnd = new Random();
            Strategy = strategies[rnd.Next(strategies.Length - 1)];
        }

        public IComputerStrategy Strategy { get; }

        public override void GetMove()
        {
            Move = Strategy.DetermineMove();
        }
    }
}
