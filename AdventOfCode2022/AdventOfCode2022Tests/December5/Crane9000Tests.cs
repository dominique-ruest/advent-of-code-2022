using AdventOfCode2022.December5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2022Tests.December5
{
    [TestClass()]
    public class Crane9000Tests
    {
        [TestMethod()]
        public void Crane9000MoveTest()
        {
            var crateInputs = new[] {
                "    [D]    ",
                "[N] [C]    ",
                "[Z] [M] [P]",
                " 1   2   3 "
            };

            var movesInputs = new[]
            {
                "move 1 from 2 to 1",
                "move 3 from 1 to 3",
                "move 2 from 2 to 1",
                "move 1 from 1 to 2"
            };

            var stacks = Day5Program.ParseStacks(crateInputs);
            var moves = Day5Program.ParseInstructions(movesInputs);

            var crane9000 = new Crane9000();

            foreach (var move in moves)
            {
                crane9000.Move(move.Quantity, stacks[move.SourceStackIndex], stacks[move.DestinationStackIndex]);
            }

            var topCrates = Day5Program.PeekTopOfStacksCrates(stacks);


            Assert.AreEqual("CMZ", topCrates);
        }

        [TestMethod()]
        public void Crane9001MoveTest()
        {
            var crateInputs = new[] {
                "    [D]    ",
                "[N] [C]    ",
                "[Z] [M] [P]",
                " 1   2   3 "
            };

            var movesInputs = new[]
            {
                "move 1 from 2 to 1",
                "move 3 from 1 to 3",
                "move 2 from 2 to 1",
                "move 1 from 1 to 2"
            };

            var stacks = Day5Program.ParseStacks(crateInputs);
            var moves = Day5Program.ParseInstructions(movesInputs);

            var crane = new Crane9001();

            foreach (var move in moves)
            {
                crane.Move(move.Quantity, stacks[move.SourceStackIndex], stacks[move.DestinationStackIndex]);
            }

            var topCrates = Day5Program.PeekTopOfStacksCrates(stacks);


            Assert.AreEqual("MCD", topCrates);
        }
    }
}