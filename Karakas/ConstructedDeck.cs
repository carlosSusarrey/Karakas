using System.Collections;
using System.Collections.Generic;

namespace Karakas
{
    public class ConstructedDeck:IDeck
    {
        public ConstructedDeck(ICollection<Card> cardList, IReadOnlyCollection<Card> sideboard)
        {
            CardList = cardList;
            Sideboard = sideboard;
        }

        public int Count => CardList.Count;
        private readonly ICollection<Card> CardList;
        public IReadOnlyCollection<Card> Sideboard { get; }

        public Card Draw()
        {
            return new Card("drawn card");
        }

        public IEnumerator<Card> GetEnumerator()
        {
            return CardList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}