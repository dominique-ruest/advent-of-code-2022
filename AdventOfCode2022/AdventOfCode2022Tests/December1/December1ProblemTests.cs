using AdventOfCode2022.December1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022Tests.December1
{
    [TestClass()]
    public class December1ProblemTests
    {
        [TestMethod()]
        public void Day1_SingleElf_CorrectSum()
        {
            var inputs = new[]
            {
                "1",
                "2",
                "3"
            };

            Assert.AreEqual(6, new December1Problem(inputs).GetCaloriesOfHighestCarryingElf());
        }

        [TestMethod()]
        public void Day1_MultipleElves_CorrectSum()
        {
            var inputs = new[]
            {
                "1",
                "2",
                "3",
                "",
                "5",
                "6"
            };

            Assert.AreEqual(11, new December1Problem(inputs).GetCaloriesOfHighestCarryingElf());
        }
    }
}