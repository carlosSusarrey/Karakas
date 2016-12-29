using System;

namespace Karakas
{
    public class GameFactory
    {
        public static Game CreateTwoPlayerGame()
        {
            return new Game(2,2);
        }

        public static Game CreateMultiplayerGame(int numberOfPlayers)
        {
            return CreateMultiplayerGame(numberOfPlayers, numberOfPlayers);
        }

        public static Game CreateMultiplayerGame(int numberOfPlayers, int numberOfTeams)
        {
            if (numberOfPlayers < 3)
            {
                throw new InvalidMultiplayerGameCreationException();
            }
            return new Game(numberOfPlayers, numberOfTeams);
        }

        public static Game CreateMultiplayerGame()
        {
            return CreateMultiplayerGame(3);
        }
    }
}