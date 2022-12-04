namespace AdventOfCode2022.December3
{
    public static class Day3Program
    {
        public static void Run()
        {
            Console.WriteLine("Day3");
            var inputs = File.ReadAllLines("December3/input.txt");
            var sumOfPriorities = inputs
                                    .Select(Rucksack.FromInput)
                                    .Select(sack => { var errors = sack.FindCompartmentLoadingErrors(); return errors.Length == 0 ? throw new Exception("This sack is fine???") : errors[0]; })
                                    .Sum(Item.GetItemPriority);

            Console.WriteLine($"Sum of priorities is {sumOfPriorities}");


            var elfGroups = inputs
                            .Chunk(3)
                            .Select(group => new ElfGroupSacks
                            {
                                Rucksacks = group.Select(Rucksack.FromInput).ToList()
                            });

            var sumOfBadges = elfGroups.Sum(group => Item.GetItemPriority(group.FindGroupBadge()));
            Console.WriteLine($"Sum of badges is {sumOfBadges}");
        }
    }
}
