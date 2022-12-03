namespace AdventOfCode2022.December3
{
    public class ElfGroupSacks
    {
        public List<Rucksack> Rucksacks { get; set; } = new();

        public char FindGroupBadge()
        {
            return Rucksacks
                .Select(sack => sack.ToString().ToCharArray())
                .Aggregate((a, b) => a.Intersect(b).ToArray())
                .Single();
        }

    }


}
