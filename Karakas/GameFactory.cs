﻿using System;

namespace Karakas
{
    public class GameFactory
    {
        public static Game CreateTwoPlayerGame()
        {
            return new Game(2);
        }

        public static Game CreateMultiplayerGame(int numberOfPlayers)
        {
            if (numberOfPlayers < 3)
            {
                throw new InvalidMultiplayerGameCreationException();
            }
            return new Game(numberOfPlayers);
        }

        public static Game CreateMultiplayerGame()
        {
            return CreateMultiplayerGame(3);
        }
    }
}