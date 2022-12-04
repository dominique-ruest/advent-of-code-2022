namespace AdventOfCode2022.December4
{
    public class Interval
    {
        public int LowerBound { get; set; }

        public int UpperBound { get; set; }

        public bool Contains(Interval other)
        {
            return LowerBound <= other.LowerBound && UpperBound >= other.UpperBound;
        }

        public bool Overlaps(Interval other)
        {
            return !(UpperBound < other.LowerBound || LowerBound > other.UpperBound);
        }

        public static Interval FromInput(string input)
        {
            var values = input.Split('-');
            return new Interval
            {
                LowerBound = int.Parse(values[0]),
                UpperBound = int.Parse(values[1]),
            };
        }
    }
}
