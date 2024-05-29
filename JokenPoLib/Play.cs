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

    public static class Play
    {
        public static PlayResult ToPlay(PlayType player1, PlayType player2)
        {
            if (player1 == player2)
                return PlayResult.Tie;

            if (player1 == PlayType.Stone && player2 == PlayType.Scissors)
                return PlayResult.Player1;

            if (player1 == PlayType.Paper && player2 == PlayType.Stone)
                return PlayResult.Player1;

            if (player1 == PlayType.Scissors && player2 == PlayType.Paper)
                return PlayResult.Player1;

            if (player2 == PlayType.Stone && player1 == PlayType.Scissors)
                return PlayResult.Player2;

            if (player2 == PlayType.Paper && player1 == PlayType.Stone)
                return PlayResult.Player2;

            if (player2 == PlayType.Scissors && player1 == PlayType.Paper)
                return PlayResult.Player2;

            return PlayResult.Tie;
        }
    }
}