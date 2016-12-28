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
        public void A_multiplayer_game_is_one_that_starts_with_more_than_two_players()
        {
            Game game = GameFactory.CreateMultiplayerGame();
            game.Players.Should().BeGreaterThan(2);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void A_multiplayer_game_should_always_start_with_more_than_two_players(int numberOfPlayers)
        {
            Game game = GameFactory.CreateMultiplayerGame(numberOfPlayers);
            game.Players.Should().BeGreaterThan(2);
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
