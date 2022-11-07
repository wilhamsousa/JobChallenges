namespace JokenPoLib
{
    public enum PlayType
    {
        Stone,
        Paper,
        Scissors
    }

    public enum PlayResult
    {
        Player1,
        Player2,
        Tie
    }

    public class Play
    {

        private PlayType Player1 { get; set; }
        private PlayType Player2 { get; set; }

        public PlayResult ToPlay(PlayType player1, PlayType player2)
        {
            Player1 = player1;
            Player2 = player2;

            if (Player1 == Player2)
                return PlayResult.Tie;

            if (Player1 == PlayType.Stone && Player2 == PlayType.Scissors)
                return PlayResult.Player1;

            if (Player1 == PlayType.Paper && Player2 == PlayType.Stone)
                return PlayResult.Player1;

            if (Player1 == PlayType.Scissors && Player2 == PlayType.Paper)
                return PlayResult.Player1;

            if (Player2 == PlayType.Stone && Player1 == PlayType.Scissors)
                return PlayResult.Player2;

            if (Player2 == PlayType.Paper && Player1 == PlayType.Stone)
                return PlayResult.Player2;

            if (Player2 == PlayType.Scissors && Player1 == PlayType.Paper)
                return PlayResult.Player2;

            return PlayResult.Tie;
        }
    }
}