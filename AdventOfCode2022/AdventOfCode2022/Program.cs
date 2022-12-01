// See https://aka.ms/new-console-template for more information
using AdventOfCode2022.December1;

Console.WriteLine("Day1");

var day1Problem = new December1Problem(File.ReadAllLines("December1/input.txt"));
Console.WriteLine(day1Problem.GetCaloriesOfHighestCarryingElf());
Console.WriteLine(day1Problem.GetCaloriesOfThreeHighestCarryingElves());

Console.WriteLine();
Console.WriteLine("Day2");
Console.WriteLine("...");