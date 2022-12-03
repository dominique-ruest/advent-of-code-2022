namespace AdventOfCode2022.December2
{
    public class StrategyGuide
    {
        public List<GameRound> GameRounds = new();

        public static StrategyGuide FromSneakyElfInputPart1(string[] input)
        {
            var strategyGuide = new StrategyGuide();
            foreach (var line in input)
            {
                var selections = line.Split(' ');

                var player1Selection = SneakyElfGuideManual.SneakyElfInputMappings[selections[0]];
                var player2Selection = SneakyElfGuideManual.SneakyElfInputMappings[selections[1]];

                strategyGuide.GameRounds.Add(new GameRound(player1Selection, player2Selection));
            }

            return strategyGuide;
        }

        public static StrategyGuide FromSneakyElfInputPart2(string[] input)
        {
            var strategyGuide = new StrategyGuide();

            foreach (var line in input)
            {
                var selections = line.Split(' ');

                var player1Selection = SneakyElfGuideManual.SneakyElfInputMappings[selections[0]];
                var player2DesiredOutcome = SneakyElfGuideManual.SneakyElfDesiredOutcomeMappings[selections[1]];
                var player2Selection = GameRoundOutcomeCalculator.GetSelectionForOutcome(player1Selection, player2DesiredOutcome);

                strategyGuide.GameRounds.Add(new GameRound(player1Selection, player2Selection));
            }

            return strategyGuide;
        }
    }
}
