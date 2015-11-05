using LeagueSharp.Common;
using LeagueSharp;
using System;

namespace Euphoric_Gentleman
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnLoad;
            CustomEvents.Game.OnGameEnd += Game_OnEnd;
        }

        private static void Game_OnLoad(EventArgs args)
        {
            Game.PrintChat("<font color=\"#00AAFF\"><b>Euphoric Gentleman</b></font> successfully loaded!");
            Utility.DelayAction.Add(new Random(Environment.TickCount).Next(25000, 50001),
                () => Game.Say("Good luck, have fun!"));
        }

        private static void Game_OnEnd(EventArgs args)
        {
            Utility.DelayAction.Add(new Random(Environment.TickCount).Next(250, 501),
                () => Game.Say("Good game, well played!"));
        }

    }
}