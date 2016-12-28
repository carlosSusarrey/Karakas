namespace Karakas
{
    public class GameFactory
    {
        public static Game CreateTwoPlayerGame()
        {
            return new Game(2);
        }

        public static Game CreateMultiplayerGame()
        {
            return new Game(3);
        }
    }
}