using System.Collections.Generic;

namespace Karakas
{
    public class ConstructedDeck:IDeck
    {
        public ConstructedDeck(ICollection<Card> cardList )
        {
            CardList = cardList;
        }

        public int CardCount => CardList.Count;
        public ICollection<Card> CardList { get; }
    }
}