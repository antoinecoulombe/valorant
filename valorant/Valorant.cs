using System;

namespace valorant
{
    static class Valorant
    {
        // Valorant.XP(0, new int[] { 20, 30, 35, 40, 45, 50 }, new DateTime(2020, 10, 2));
        public static void XP(int currentLevel, int[] destinationLevels, DateTime seasonEnd)
        {
            if (seasonEnd < DateTime.Now)
            {
                Console.WriteLine("Season end date cannot be before current date.");
                return;
            }

            XP xp = new(currentLevel, seasonEnd);
            xp.WriteSetup();
            xp.Write(destinationLevels);
        }

        // Valorant.MapSelector(new string[] { "Player1", "Player2", "Player3", "Player4", "Player5" });
        public static void MapSelector(string[] playerNames)
        {
            string[] players = playerNames;
            MapSelector mapSelector = new(players);
            mapSelector.PlayRandomAsTeam();
            mapSelector.PlayRandomAsTeam();
            mapSelector.PlayRandomAsTeam();
            mapSelector.PlayRandomAsTeam();

            mapSelector.SwitchPlayer("Player2", "Player6");
            mapSelector.PlayRandomAsTeam();
        }
    }
}
