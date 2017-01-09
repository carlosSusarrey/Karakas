using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        public Tuple<Card, IDeck> Draw()
        {
            return Tuple.Create<Card,IDeck>(this.First(), new ConstructedDeck(this.Skip(1).ToList(),Sideboard));
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