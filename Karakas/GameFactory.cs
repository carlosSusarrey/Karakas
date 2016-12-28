namespace Karakas
{
    public class GameFactory
    {
        public static Game CreateTwoPlayerGame()
        {
            return new Game(2);
        }
    }
}