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
            game.PlayerCount.Should().Be(2);
        }

        [Fact]
        public void A_multiplayer_game_is_one_that_starts_with_more_than_two_players()
        {
            var game = GameFactory.CreateMultiplayerGame();
            game.PlayerCount.Should().BeGreaterThan(2);
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
            game.PlayerCount.Should().Be(numberOfPlayers);
        }

        [Fact]
        public void In_a_two_player_game_there_are_two_teams()
        {
            var game = GameFactory.CreateTwoPlayerGame();
            game.Teams.Count.Should().Be(2);
        }

        [Fact]
        public void In_a_multiplayer_game_there_can_be_more_than_two_teams()
        {
            var game = GameFactory.CreateMultiplayerGame(3);
            game.Teams.Count.Should().Be(3);
        }

        [Fact]
        public void In_a_multiplayer_game_there_can_be_less_teams_than_there_are_players()
        {
            var game = GameFactory.CreateMultiplayerGame(4, 2);
            game.Teams.Count.Should().Be(2);
        }
    }
}
