using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppPhaseEndProject1
{
    class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }

        public void Add(Player player)
        {
            oneDayTeam.Add(player);
            Console.WriteLine($"Player {player.PlayerName} added successfully.");
        }

        public void Remove(int playerId)
        {
            Player playerToRemove = oneDayTeam.Find(p => p.PlayerId == playerId);

            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine($"Player {playerToRemove.PlayerName} removed successfully.");
            }
            else
            {
                Console.WriteLine($"Player with ID {playerId} not found.");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            Player player = oneDayTeam.Find(p => p.PlayerId == playerId);
            return player;
        }

        public Player GetPlayerByName(string playerName)
        {
            Player player = oneDayTeam.Find(p => p.PlayerName == playerName);
            return player;
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}
