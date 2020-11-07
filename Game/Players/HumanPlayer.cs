using RockPaperScissors.Game.Moves;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace RockPaperScissors.Game.Players
{
    class HumanPlayer : BasePlayer
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        public IMoveType GetMove()
        {
            while (true)
            {
                Console.WriteLine("Please enter your move: ");
                Console.WriteLine("(R)ock");
                Console.WriteLine("(S)cissors");
                Console.WriteLine("(P)aper");
                string moveInp = Console.ReadLine();

                switch (moveInp)
                {
                    case "R":
                        return new Rock();
                    case "S":
                        return new Scissors();
                    case "P":
                        return new Paper();
                    default:
                        Console.WriteLine("Invalid entry, please try again");
                        break;
                }
            }
        }
    }
}
