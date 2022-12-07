using AdventOfCode2022.December6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022Tests.December6
{
    [TestClass()]
    public class Day6ProgramTests
    {
        [TestMethod()]
        [DataRow("bvwbjplbgvbhsrlpgdmjqwftvncz", 4, 5)]
        [DataRow("nppdvjthqldpwncqszvftbrmjlhg", 4, 6)]
        [DataRow("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 4, 10)]
        [DataRow("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 4, 11)]
        [DataRow("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 14, 19)]
        [DataRow("bvwbjplbgvbhsrlpgdmjqwftvncz", 14, 23)]
        [DataRow("nppdvjthqldpwncqszvftbrmjlhg", 14, 23)]
        [DataRow("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 14, 29)]
        [DataRow("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 14, 26)]
        public void FindUniqueMarkerEndIndexTest(string input, int markerLength, int expectedCharacterEndPosition)
        {
            Assert.AreEqual(expectedCharacterEndPosition, Day6Program.FindUniqueMarkerEndIndexClevererApproach(input, markerLength) + 1);
        }
    }
}