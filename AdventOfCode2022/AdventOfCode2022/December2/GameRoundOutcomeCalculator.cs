namespace AdventOfCode2022.December2
{
    public static class GameRoundOutcomeCalculator
    {
        private static readonly Dictionary<RockPaperScissorSelection, Dictionary<RockPaperScissorSelection, RoundOutcome>> RoundOutcomes = new()
        {
            {
                RockPaperScissorSelection.Rock, new Dictionary<RockPaperScissorSelection, RoundOutcome>
                {
                    { RockPaperScissorSelection.Rock, RoundOutcome.Draw },
                    { RockPaperScissorSelection.Paper, RoundOutcome.Player2Wins },
                    { RockPaperScissorSelection.Scissor, RoundOutcome.Player1Wins },
                }
            },
            {
                RockPaperScissorSelection.Paper, new Dictionary<RockPaperScissorSelection, RoundOutcome>
                {
                    { RockPaperScissorSelection.Rock, RoundOutcome.Player1Wins },
                    { RockPaperScissorSelection.Paper, RoundOutcome.Draw },
                    { RockPaperScissorSelection.Scissor, RoundOutcome.Player2Wins },
                }
            },
            {
                RockPaperScissorSelection.Scissor, new Dictionary<RockPaperScissorSelection, RoundOutcome>
                {
                    { RockPaperScissorSelection.Rock, RoundOutcome.Player2Wins },
                    { RockPaperScissorSelection.Paper, RoundOutcome.Player1Wins },
                    { RockPaperScissorSelection.Scissor, RoundOutcome.Draw },
                }
            }
        };

        public static RoundOutcome GetRoundOutcome(RockPaperScissorSelection player1Selection, RockPaperScissorSelection player2Selection)
        {
            return RoundOutcomes[player1Selection][player2Selection];
        }
    }
}
