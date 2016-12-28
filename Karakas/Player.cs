using System.Collections.Generic;

namespace Karakas
{
    public class Player
    {

        public ICollection<Player> Opponents { get; }

        public Player()
        {
            Opponents = new List<Player>();
        }

        public Player(Player opponent)
        {
            Opponents = new List<Player> {opponent};
        }
    }
}