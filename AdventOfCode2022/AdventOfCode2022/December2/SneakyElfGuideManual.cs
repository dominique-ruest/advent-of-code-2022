namespace AdventOfCode2022.December2
{
    public static class SneakyElfGuideManual
    {
        public static readonly Dictionary<string, RockPaperScissorSelection> SneakyElfInputMappings = new()
        {
            { "A", RockPaperScissorSelection.Rock },
            { "B", RockPaperScissorSelection.Paper },
            { "C", RockPaperScissorSelection.Scissor },
            { "X", RockPaperScissorSelection.Rock },
            { "Y", RockPaperScissorSelection.Paper },
            { "Z", RockPaperScissorSelection.Scissor }
        };

        public static readonly Dictionary<string, RoundOutcome> SneakyElfDesiredOutcomeMappings = new()
        {
            { "X", RoundOutcome.Player1Wins },
            { "Y", RoundOutcome.Draw },
            { "Z", RoundOutcome.Player2Wins }
        };


        public static readonly Dictionary<RockPaperScissorSelection, Dictionary<RoundOutcome, RockPaperScissorSelection>> SneakyElfInputDesiredOutcomeMappings = new()
        {
            {
                RockPaperScissorSelection.Rock, new Dictionary<RoundOutcome, RockPaperScissorSelection>
                {
                    { RoundOutcome.Draw, RockPaperScissorSelection.Rock },
                    { RoundOutcome.Player2Wins, RockPaperScissorSelection.Paper  },
                    { RoundOutcome.Player1Wins, RockPaperScissorSelection.Scissor },
                }
            },
            {
                RockPaperScissorSelection.Paper, new Dictionary<RoundOutcome, RockPaperScissorSelection>
                {
                    { RoundOutcome.Player1Wins, RockPaperScissorSelection.Rock },
                    { RoundOutcome.Draw, RockPaperScissorSelection.Paper },
                    { RoundOutcome.Player2Wins, RockPaperScissorSelection.Scissor },
                }
            },
            {
                RockPaperScissorSelection.Scissor, new Dictionary<RoundOutcome, RockPaperScissorSelection>
                {
                    { RoundOutcome.Player2Wins, RockPaperScissorSelection.Rock },
                    { RoundOutcome.Player1Wins, RockPaperScissorSelection.Paper },
                    { RoundOutcome.Draw, RockPaperScissorSelection.Scissor },
                }
            }
        };
    }
}
