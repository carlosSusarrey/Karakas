using System.Collections.Generic;

namespace Karakas
{
    public class Game
    {
        internal Game(int playerCount, int numberOfTeams)
        {
            this.PlayerCount = playerCount;
            Teams = new List<Team>();
            for (var i = 0; i < numberOfTeams; i++)
            {
                Teams.Add(new Team());
            }   
        }

        public int PlayerCount { get; }
        public ICollection<Team> Teams { get; }
    }
}