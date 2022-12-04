namespace AdventOfCode2022.December4
{
    public static class Day4Program
    {
        public static void Run()
        {
            Console.WriteLine("Day4");

            var day4Inputs = File.ReadAllLines("December4/input.txt");
            var pairs = day4Inputs.Select(input =>
            {
                var intervals = input.Split(',');
                var elf1Assignment = Interval.FromInput(intervals[0]);
                var elf2Assignment = Interval.FromInput(intervals[1]);
                return (elf1Assignment, elf2Assignment);
            }).ToList();

            var fullyContainedCount = pairs.Count((pair) => pair.elf1Assignment.Contains(pair.elf2Assignment) || pair.elf2Assignment.Contains(pair.elf1Assignment));

            var overlapsCount = pairs.Count((pair) => pair.elf1Assignment.Overlaps(pair.elf2Assignment));

            Console.WriteLine("Assignment pairs with one pair fully containing the other: " + fullyContainedCount);
            Console.WriteLine("Assignment pairs with overlaps: " + overlapsCount);
        }
    }
}
