using AdventOfCode2022.December4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022Tests.December4
{
    [TestClass()]
    public class IntervalTests
    {
        [TestMethod()]
        [DataRow("4-6", "6-6", true)]
        [DataRow("2-8", "3-7", true)]
        [DataRow("3-7", "2-8", false)]
        public void ContainsTest(string interval1Input, string interval2Input, bool interval1ContainsInterval2)
        {
            var interval1 = Interval.FromInput(interval1Input);
            var interval2 = Interval.FromInput(interval2Input);
            Assert.AreEqual(interval1ContainsInterval2, interval1.Contains(interval2));
        }

        [TestMethod()]
        [DataRow("2-4", "6-8", false)]
        [DataRow("4-6", "6-6", true)]
        [DataRow("4-6", "6-6", true)]
        [DataRow("2-8", "3-7", true)]
        [DataRow("3-7", "2-8", true)]
        public void OverlapsTest(string interval1Input, string interval2Input, bool interval1OverlapsInterval2)
        {
            var interval1 = Interval.FromInput(interval1Input);
            var interval2 = Interval.FromInput(interval2Input);
            Assert.AreEqual(interval1OverlapsInterval2, interval1.Overlaps(interval2));
        }
    }
}