using AdventOfCode2022.December3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022Tests.December3
{
    [TestClass()]

    public class ElfGroupSacksTests
    {
        [TestMethod()]
        [DataRow(new string[] { "vJrwpWtwJgWrhcsFMMfFFhFp", "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "PmmdzqPrVvPwwTWBwg" }, 18)]
        [DataRow(new string[] { "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", "ttgJtRGJQctTZtZT", "CrZsJsPPZsGzwwsLwLmpwMDw" }, 52)]
        public void FindGroupBadgeTest(string[] sacks, int expectedPriority)
        {
            var groupSacks = new ElfGroupSacks
            {
                Rucksacks = sacks.Select(Rucksack.FromInput).ToList(),
            };

            Assert.AreEqual(expectedPriority, Item.GetItemPriority(groupSacks.FindGroupBadge()));
        }
    }
}