namespace AdventOfCode2022.December2
{
    public class GameRound
    {


        public GameRound(RockPaperScissorSelection player1Selection, RockPaperScissorSelection player2Selection)
        {
            Player1Selection = player1Selection;
            Player2Selection = player2Selection;
            ComputeScore();
        }

        public RockPaperScissorSelection Player1Selection { get; }
        public RockPaperScissorSelection Player2Selection { get; }

        public int Player1Score { get; private set; }

        public int Player2Score { get; private set; }

        public RoundOutcome RoundOutcome { get; private set; }

        private void ComputeScore()
        {
            RoundOutcome = GameRoundOutcomeCalculator.GetRoundOutcome(Player1Selection, Player2Selection);

            Player1Score = (int)Player1Selection + (RoundOutcome == RoundOutcome.Player1Wins ? 6 : RoundOutcome == RoundOutcome.Draw ? 3 : 0);
            Player2Score = (int)Player2Selection + (RoundOutcome == RoundOutcome.Player2Wins ? 6 : RoundOutcome == RoundOutcome.Draw ? 3 : 0);
        }
    }
}
