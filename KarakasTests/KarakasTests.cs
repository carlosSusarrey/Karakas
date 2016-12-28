using System;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Karakas;
using Xunit;

namespace KarakasTests
{
    public class KarakasTests
    {
        [Fact]
        public void A_Player_can_have_no_opponents()
        {
            var player = new Player();
            player.Opponents.Should().BeEmpty();
        }
    }
}
