using AdventOfCode2022.December3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022Tests.December3
{
    [TestClass()]
    public class RucksackTests
    {
        [TestMethod()]
        [DataRow("vJrwpWtwJgWrhcsFMMfFFhFp", 16)]
        [DataRow("jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", 38)]
        [DataRow("PmmdzqPrVvPwwTWBwg", 42)]
        [DataRow("wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", 22)]
        [DataRow("ttgJtRGJQctTZtZT", 20)]
        [DataRow("CrZsJsPPZsGzwwsLwLmpwMDw", 19)]
        [DataRow("BsRsnmBQdNWsvRPzbzbLzDVSPSbVLM", 42)]
        public void FindCompartmentLoadingErrorsTest(string input, int expectedPriority)
        {
            var rucksack = Rucksack.FromInput(input);
            Assert.AreEqual(expectedPriority, Item.GetItemPriority(rucksack.FindCompartmentLoadingErrors().Single()));
        }
    }
}