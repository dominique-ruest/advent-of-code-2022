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
    }
}
