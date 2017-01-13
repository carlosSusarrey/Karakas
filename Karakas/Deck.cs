using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Karakas
{
    public class Deck:IDeck
    {
        public Deck(ICollection<Card> cardList, IReadOnlyCollection<Card> sideboard)
        {
            Sideboard = sideboard;
            CardList = cardList;   
        }


        public int Count => CardList.Count;
        public IReadOnlyCollection<Card> Sideboard { get; }
        private readonly ICollection<Card> CardList;
        

        public Tuple<Card, IDeck> Draw()
        {
            return Tuple.Create<Card,IDeck>(this.First(), new Deck(this.Skip(1).ToList(),Sideboard));
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