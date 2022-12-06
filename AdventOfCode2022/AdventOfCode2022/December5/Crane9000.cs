namespace AdventOfCode2022.December5
{
    public class Crane9000
    {
        public void Move(int quantity, Stack<char> sourceStack, Stack<char> destinationStack)
        {
            for (var i = 0; i < quantity; i++)
            {
                destinationStack.Push(sourceStack.Pop());
            }

        }
    }
}
