using System.Text;

namespace AdventOfCode2022.December5
{
    public static class Day5Program
    {
        private const int CrateWidth = 3;
        private const int CrateSpacing = 1;

        public static void Run()
        {
            var inputs = File.ReadAllLines("December5/input-crates.txt");
            var stacks = ParseStacks(inputs);

            var moves = File.ReadAllLines("December5/input-moves.txt");
            var instructions = ParseInstructions(moves);

            var crane9000 = new Crane9000();

            foreach (var move in instructions)
            {
                crane9000.Move(move.Quantity, stacks[move.SourceStackIndex], stacks[move.DestinationStackIndex]);
            }

            Console.WriteLine("Top of stack after crane 9000 moves: " + PeekTopOfStacksCrates(stacks));


            var crane9001 = new Crane9001();
            stacks = ParseStacks(inputs);

            foreach (var move in instructions)
            {
                crane9001.Move(move.Quantity, stacks[move.SourceStackIndex], stacks[move.DestinationStackIndex]);
            }

            Console.WriteLine("Top of stack after crane 9001 moves: " + PeekTopOfStacksCrates(stacks));


            var topOfStackItemsStringBuilder = PeekTopOfStacksCrates(stacks);

            Console.WriteLine(topOfStackItemsStringBuilder.ToString());
        }

        public static IEnumerable<MoveInstruction> ParseInstructions(string[] inputs)
        {
            var instructions = inputs.Select(move =>
            {
                var moveParams = move.Split(' ');
                var quantityToMove = int.Parse(moveParams[1]);
                var sourceStackIndex = int.Parse(moveParams[3]) - 1;
                var destinationStackIndex = int.Parse(moveParams[5]) - 1;

                return new MoveInstruction
                {
                    Quantity = quantityToMove,
                    SourceStackIndex = sourceStackIndex,
                    DestinationStackIndex = destinationStackIndex
                };
            });
            return instructions;
        }

        public static string PeekTopOfStacksCrates(List<Stack<char>> stacks)
        {
            var topOfStackItemsStringBuilder = new StringBuilder();
            var topOfStackItems = stacks.Select(stack => stack.Peek()).ToList();
            foreach (var item in topOfStackItems)
            {
                _ = topOfStackItemsStringBuilder.Append(item);
            }

            return topOfStackItemsStringBuilder.ToString();
        }

        public static List<Stack<char>> ParseStacks(string[] inputs)
        {

            var numberOfCrates = (inputs[0].Length + CrateSpacing) / (CrateWidth + CrateSpacing);
            var stacks = new List<Stack<char>>(numberOfCrates);
            for (var crateIndex = 0; crateIndex < numberOfCrates; crateIndex++)
            {
                var stack = new Stack<char>();
                for (var j = inputs.Length - 1; j >= 0; j--)
                {
                    var crate = inputs[j][((CrateSpacing + CrateWidth) * crateIndex) + 1];
                    if (crate == ' ')
                    {
                        break;
                    }

                    stack.Push(crate);
                }

                stacks.Add(stack);
            }

            return stacks;
        }
    }
}
