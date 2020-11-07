using RockPaperScissors.Game;
using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Rock rock = new Rock();

            Console.WriteLine(rock.CanBeat(rock));
        }
    }
}
