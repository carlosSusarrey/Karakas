
namespace Karakas
{
    public class DeckFactory
    {
        public static ConstructedDeck CreateConstrutedDeck()
        {
            return new ConstructedDeck(60);
        }
    }
}