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


        public static readonly Dictionary<(RockPaperScissorSelection, RoundOutcome), RockPaperScissorSelection> SneakyElfInputDesiredOutcomeMappings = new()
        {
            { (RockPaperScissorSelection.Rock,  RoundOutcome.Draw), RockPaperScissorSelection.Rock },
            { (RockPaperScissorSelection.Rock,  RoundOutcome.Player2Wins), RockPaperScissorSelection.Paper },
            { (RockPaperScissorSelection.Rock,  RoundOutcome.Player1Wins), RockPaperScissorSelection.Scissor },
            { (RockPaperScissorSelection.Paper,  RoundOutcome.Draw), RockPaperScissorSelection.Paper },
            { (RockPaperScissorSelection.Paper,  RoundOutcome.Player2Wins), RockPaperScissorSelection.Scissor },
            { (RockPaperScissorSelection.Paper,  RoundOutcome.Player1Wins), RockPaperScissorSelection.Rock },
            { (RockPaperScissorSelection.Scissor,  RoundOutcome.Draw), RockPaperScissorSelection.Scissor },
            { (RockPaperScissorSelection.Scissor,  RoundOutcome.Player2Wins), RockPaperScissorSelection.Rock },
            { (RockPaperScissorSelection.Scissor,  RoundOutcome.Player1Wins), RockPaperScissorSelection.Paper }
        };
    }
}
