namespace AdventOfCode2022.December2
{
    public static class Day2Program
    {
        public static void Run()
        {
            Console.WriteLine("Day2");

            var strategyGuide = StrategyGuide.FromSneakyElfInputPart1(File.ReadAllLines("December2/input.txt"));
            var player2TotalScore = strategyGuide.GameRounds.Sum(p => p.Player2Score);
            Console.WriteLine($"Using the super sneaky elf guide you would get a score of {player2TotalScore}");

            var strategyGuidePart2 = StrategyGuide.FromSneakyElfInputPart2(File.ReadAllLines("December2/input.txt"));
            var player2TotalScorePart2 = strategyGuidePart2.GameRounds.Sum(p => p.Player2Score);
            Console.WriteLine($"Using the super sneaky elf guide PART 2 you would get a score of {player2TotalScorePart2}");
        }
    }
}
