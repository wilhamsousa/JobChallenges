using JokenPoLib;

namespace JokenPoTest
{
    public class PlayTest
    {
        public PlayTest()
        {
        }

        [Fact]
        public void Tie1() => Assert.Equal(PlayResult.Tie, Play.ToPlay(PlayType.Scissors, PlayType.Scissors));

        [Fact]
        public void Tie2() => Assert.Equal(PlayResult.Tie, Play.ToPlay(PlayType.Stone, PlayType.Stone));

        [Fact]
        public void Tie3() => Assert.Equal(PlayResult.Tie, Play.ToPlay(PlayType.Paper, PlayType.Paper));

        [Fact]
        public void Player1Wins1() => Assert.Equal(PlayResult.Player1, Play.ToPlay(PlayType.Scissors, PlayType.Paper));

        [Fact]
        public void Player1Wins2() => Assert.Equal(PlayResult.Player1, Play.ToPlay(PlayType.Stone, PlayType.Scissors));

        [Fact]
        public void Player1Wins3() => Assert.Equal(PlayResult.Player1, Play.ToPlay(PlayType.Paper, PlayType.Stone));

        [Fact]
        public void Player2Wins1() => Assert.Equal(PlayResult.Player2, Play.ToPlay(PlayType.Paper, PlayType.Scissors));

        [Fact]
        public void Player2Wins2() => Assert.Equal(PlayResult.Player2, Play.ToPlay(PlayType.Scissors, PlayType.Stone));

        [Fact]
        public void Player2Wins3() => Assert.Equal(PlayResult.Player2, Play.ToPlay(PlayType.Stone, PlayType.Paper));

    }
}