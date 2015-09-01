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
            Game.PrintChat("<font color=\"#55FF00\"><b>Euphoric</b></font> <font color=\"#00AAFF\"><b>Gentleman</b></font> successfully loaded!");
            Utility.DelayAction.Add((new Random(Environment.TickCount).Next(1000, 10001)), () => Game.Say("/all glhf"));
        }

        private static void Game_OnEnd(EventArgs args)
        {
            Utility.DelayAction.Add((new Random(Environment.TickCount).Next(100, 1001)), () => Game.Say("/all ggwp"));
        }
    }
}