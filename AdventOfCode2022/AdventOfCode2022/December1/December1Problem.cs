namespace AdventOfCode2022.December1
{
    public class December1Problem
    {
        private readonly List<int> elfTotalCalories = new() { 0 };

        public December1Problem(string[] input)
        {
            ParseElvesTotalCalories(input);
        }

        public int GetCaloriesOfHighestCarryingElf()
        {
            return elfTotalCalories.OrderByDescending(p => p).First();
        }

        public int GetCaloriesOfThreeHighestCarryingElves()
        {
            return elfTotalCalories.OrderByDescending(p => p).Take(3).Sum();
        }

        private void ParseElvesTotalCalories(string[] input)
        {
            foreach (var line in input)
            {
                if (line == string.Empty)
                {
                    elfTotalCalories.Add(0);
                }
                else
                {
                    elfTotalCalories[^1] += int.Parse(line);
                }
            }
        }
    }
}
