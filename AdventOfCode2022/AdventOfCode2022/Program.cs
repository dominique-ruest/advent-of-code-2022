// See https://aka.ms/new-console-template for more information
using AdventOfCode2022.December1;
using AdventOfCode2022.December2;

Console.WriteLine("Day1");

var day1Problem = new December1Problem(File.ReadAllLines("December1/input.txt"));
Console.WriteLine(day1Problem.GetLargestAmountOfCaloriesCarriedBySingleElf());
Console.WriteLine(day1Problem.GetLargestAmountOfCaloriesCarriedByThreeElves());
Console.WriteLine();

Console.WriteLine("Day2");

var strategyGuide = StrategyGuide.FromSneakyElfInputPart1(File.ReadAllLines("December2/input.txt"));
var player2TotalScore = strategyGuide.GameRounds.Sum(p => p.Player2Score);
Console.WriteLine($"Using the super sneaky elf guide you would get a score of {player2TotalScore}");

var strategyGuidePart2 = StrategyGuide.FromSneakyElfInputPart2(File.ReadAllLines("December2/input.txt"));
var player2TotalScorePart2 = strategyGuidePart2.GameRounds.Sum(p => p.Player2Score);
Console.WriteLine($"Using the super sneaky elf guide PART 2 you would get a score of {player2TotalScorePart2}");