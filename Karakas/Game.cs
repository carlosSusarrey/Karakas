using System.Collections.Generic;

namespace Karakas
{
    public class Game
    {
        internal Game(int playerCount)
        {
            this.PlayerCount = playerCount;
            Teams = new List<Team>();
            for (var i = 0; i < playerCount; i++)
            {
                Teams.Add(new Team());
            }   
        }

        public int PlayerCount { get; }
        public ICollection<Team> Teams { get; }
    }
}