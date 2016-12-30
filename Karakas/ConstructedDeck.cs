namespace Karakas
{
    public class ConstructedDeck:Deck
    {
        public ConstructedDeck(int cards)
        {
            this.Cards = cards;
        }

        public int Cards { get; }
    }
}