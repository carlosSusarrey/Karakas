using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Karakas;
using Xunit;

namespace KarakasTests
{
    public class GameTests
    {
        [Fact]
        public void A_two_player_game_is_one_that_has_only_two_players()
        {
            Game game = GameFactory.CreateTwoPlayerGame();
            game.Players.Should().Be(2);
        }

        [Fact]
        public void A_Player_can_have_no_opponents()
        {
            var player = new Player();
            player.Opponents.Should().BeEmpty();
        }

        [Fact]
        public void A_Player_can_have_one_Opponent()
        {
            var opponent = new Player();
            var player = new Player(opponent);
            player.Opponents.Count.Should().Be(1);
        }

    }
}
