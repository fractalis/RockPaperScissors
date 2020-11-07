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
            IComputerStrategy[] strategies = new IComputerStrategy[] { new RockStrategy(), new RandomStrategy() };
            Random rnd = new Random();
            var idx = rnd.Next(strategies.Length);
            Strategy = strategies[idx];
        }

        public IComputerStrategy Strategy { get; }

        public override void GetMove()
        {
            Move = Strategy.DetermineMove();
        }
    }
}
