using System;
using System.Collections.Generic;
using System.Text;
using RockPaperScissors.Game.Moves;

namespace RockPaperScissors.Game
{
    abstract class BasePlayer
    {
        public BasePlayer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int Score { get; private set; }

        public IMoveType Move { get; internal set; }

        public abstract void GetMove();

        public void IncrementScore() { Score += 1; }
    }
}
