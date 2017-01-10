﻿
using System;
using System.Collections.Generic;

namespace Karakas
{
    public class DeckFactory
    {
        public static IDeck CreateConstrutedDeck()
        {
            return CreateConstrutedDeck(60);
        }

        public static IDeck CreateConstrutedDeck(int numberOfCards)
        {
            var cardList = new List<Card>();
            numberOfCards = numberOfCards > 60 ? numberOfCards : 60;
            for (var i = 0; i < numberOfCards; i++)
            {
                cardList.Add(new Card("main deck card"));
            }

            var sideboard = new List<Card>();

            for (var i = 0; i < 15; i++)
            {
                sideboard.Add(new Card("sideboard card"));
            }

            return new ConstructedDeck(cardList, sideboard);
        }
    }
}