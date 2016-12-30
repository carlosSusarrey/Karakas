using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using Karakas;

namespace KarakasTests
{
    public class DeckTests
    {
        [Fact]
        public void A_constructed_deck_has_at_least_60_cards()
        {
            Deck construtedDeck = DeckFactory.CreateConstrutedDeck();
            construtedDeck.Cards.Should().BeGreaterThan(59);
        }
        
    }
}
