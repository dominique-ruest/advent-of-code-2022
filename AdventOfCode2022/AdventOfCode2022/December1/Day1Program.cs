namespace AdventOfCode2022.December1
{
    public static class Day1Program
    {
        public static void Run()
        {
            Console.WriteLine("Day1");
            var day1Problem = new December1Problem(File.ReadAllLines("December1/input.txt"));
            Console.WriteLine(day1Problem.GetLargestAmountOfCaloriesCarriedBySingleElf());
            Console.WriteLine(day1Problem.GetLargestAmountOfCaloriesCarriedByThreeElves());
        }
    }
}
