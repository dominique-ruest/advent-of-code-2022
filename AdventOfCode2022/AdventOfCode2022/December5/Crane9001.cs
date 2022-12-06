namespace AdventOfCode2022.December5
{
    public class Crane9001
    {
        public void Move(int quantity, Stack<char> sourceStack, Stack<char> destinationStack)
        {
            var craneStack = new Stack<char>();
            for (var i = 0; i < quantity; i++)
            {
                craneStack.Push(sourceStack.Pop());
            }

            while (craneStack.Count > 0)
            {
                destinationStack.Push(craneStack.Pop());
            }
        }
    }
}
