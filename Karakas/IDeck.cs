using System;
using System.Collections;
using System.Collections.Generic;

namespace Karakas
{
    public interface IDeck:IReadOnlyCollection<Card>
    {
        IReadOnlyCollection<Card> Sideboard { get;}
        Tuple<Card,IDeck> Draw();
    }
}