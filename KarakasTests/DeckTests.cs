﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Functional.Option;
using Xunit;
using Karakas;

namespace KarakasTests
{
    public class DeckTests
    {
        [Fact]
        public void A_constructed_deck_has_at_least_60_cards()
        {
            IDeck construtedDeck = DeckFactory.CreateConstrutedDeck();
            construtedDeck.Count.Should().BeGreaterThan(59);
        }

        [Fact]
        public void A_constructed_deck_can_have_more_than_60_cards()
        {
            int arbitrary_number_of_cards = 80;
            IDeck constructeDeck = DeckFactory.CreateConstrutedDeck(arbitrary_number_of_cards);
            constructeDeck.Count.Should().Be(arbitrary_number_of_cards);
        }

        [Fact]
        public void A_deck_can_have_a_card_drawn()
        {
            int arbitrary_number_of_cards = 60;
            IDeck deck = DeckFactory.CreateConstrutedDeck(arbitrary_number_of_cards);
            Card myCard = deck.Draw();
            myCard.Should().NotBeNull();
        }

        [Fact]
        public void A_constructed_deck_has_a_sideboard()
        {
            IDeck constructeDeck = DeckFactory.CreateConstrutedDeck();
            constructeDeck.Sideboard.Should().NotBeNull();
        }
    }
}
