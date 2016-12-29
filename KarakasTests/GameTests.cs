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
            var game = GameFactory.CreateTwoPlayerGame();
            game.Players.Should().Be(2);
        }

        [Fact]
        public void A_multiplayer_game_is_one_that_starts_with_more_than_two_players()
        {
            var game = GameFactory.CreateMultiplayerGame();
            game.Players.Should().BeGreaterThan(2);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void A_multiplayer_game_cant_start_with_less_than_three_players(int numberOfPlayers)
        {
            Action createInvalidGame = () => GameFactory.CreateMultiplayerGame(numberOfPlayers);
            createInvalidGame.ShouldThrow<InvalidMultiplayerGameCreationException>();

        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void A_multiplayer_game_should_always_start_with_multiple_players(int numberOfPlayers)
        {
            var game = GameFactory.CreateMultiplayerGame(numberOfPlayers);
            game.Players.Should().Be(numberOfPlayers);
        }
    }
}
