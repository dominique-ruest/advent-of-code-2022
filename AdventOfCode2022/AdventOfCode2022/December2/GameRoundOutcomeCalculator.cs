namespace AdventOfCode2022.December2
{
    public static class GameRoundOutcomeCalculator
    {
        private static readonly Dictionary<(RockPaperScissorSelection, RockPaperScissorSelection), RoundOutcome> RoundOutcomes = new()
        {
            { (RockPaperScissorSelection.Rock, RockPaperScissorSelection.Rock), RoundOutcome.Draw },
            { (RockPaperScissorSelection.Rock, RockPaperScissorSelection.Paper), RoundOutcome.Player2Wins },
            { (RockPaperScissorSelection.Rock, RockPaperScissorSelection.Scissor), RoundOutcome.Player1Wins },
            { (RockPaperScissorSelection.Paper, RockPaperScissorSelection.Rock), RoundOutcome.Player1Wins },
            { (RockPaperScissorSelection.Paper, RockPaperScissorSelection.Paper), RoundOutcome.Draw },
            { (RockPaperScissorSelection.Paper, RockPaperScissorSelection.Scissor), RoundOutcome.Player2Wins },
            { (RockPaperScissorSelection.Scissor, RockPaperScissorSelection.Rock), RoundOutcome.Player2Wins },
            { (RockPaperScissorSelection.Scissor, RockPaperScissorSelection.Paper), RoundOutcome.Player1Wins },
            { (RockPaperScissorSelection.Scissor, RockPaperScissorSelection.Scissor), RoundOutcome.Draw }
        };

        public static RoundOutcome GetRoundOutcome(RockPaperScissorSelection player1Selection, RockPaperScissorSelection player2Selection)
        {
            return RoundOutcomes[(player1Selection, player2Selection)];
        }
    }
}
