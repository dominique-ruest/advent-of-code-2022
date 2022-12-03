using AdventOfCode2022.December2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022Tests.December2
{
    [TestClass()]
    public class StrategyGuideTests
    {
        [TestMethod()]
        [DataRow(new[] { "A Y", "B X", "C Z" }, 15)]
        public void TotalScore(string[] input, int expectedPlayer1Score)
        {
            var score = StrategyGuide.FromSneakyElfInputPart1(input)
                            .GameRounds
                            .Sum(p => p.Player2Score);

            Assert.AreEqual(expectedPlayer1Score, score);
        }

        [TestMethod()]
        [DataRow(new[] { "A Y", "B X", "C Z" }, 12)]
        public void TotalScorePart2(string[] input, int expectedPlayer1Score)
        {
            var score = StrategyGuide.FromSneakyElfInputPart2(input)
                            .GameRounds
                            .Sum(p => p.Player2Score);

            Assert.AreEqual(expectedPlayer1Score, score);
        }
    }
}