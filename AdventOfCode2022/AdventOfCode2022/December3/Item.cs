namespace AdventOfCode2022.December3
{
    public class Item
    {
        public static int GetItemPriority(char item)
        {
            return item > 'a' ? (1 + item - 'a') : (27 + item - 'A');
        }
    }
}
