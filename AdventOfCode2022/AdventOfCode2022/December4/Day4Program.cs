namespace AdventOfCode2022.December4
{
    public static class Day4Program
    {
        public static void Run()
        {
            Console.WriteLine("Day4");

            var day4Inputs = File.ReadAllLines("December4/input.txt");

            var fullyContainedCount = day4Inputs.Select(input =>
            {
                var intervals = input.Split(',');
                var elf1Assignment = Interval.FromInput(intervals[0]);
                var elf2Assignment = Interval.FromInput(intervals[1]);
                return (elf1Assignment.Contains(elf2Assignment) || elf2Assignment.Contains(elf1Assignment)) ? 1 : 0;
            })
            .Sum();

            var overlapsCount = day4Inputs.Select(input =>
            {
                var intervals = input.Split(',');
                var elf1Assignment = Interval.FromInput(intervals[0]);
                var elf2Assignment = Interval.FromInput(intervals[1]);
                return elf1Assignment.Overlaps(elf2Assignment) ? 1 : 0;
            })
            .Sum();

            Console.WriteLine("Assignment pairs with one pair fully containing the other: " + fullyContainedCount);
            Console.WriteLine("Assignment pairs with overlaps: " + overlapsCount);
        }
    }
}
