using System.Collections;
using System.Collections.Generic;

namespace Karakas
{
    public interface IDeck
    {
        int CardCount { get; }
        ICollection<Card> CardList { get; }
    }
}