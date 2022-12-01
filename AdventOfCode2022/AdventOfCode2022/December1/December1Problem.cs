namespace AdventOfCode2022.December1;

public class December1Problem
{
    private readonly List<Elf> elves = new() { new Elf() };

    public December1Problem(string[] input)
    {
        PreComputeTotalCaloriesCarriedByElf(input);
    }

    public int GetLargestAmountOfCaloriesCarriedBySingleElf()
    {
        return elves
            .OrderByDescending(p => p.TotalFoodCaloriesCarried)
            .First()
            .TotalFoodCaloriesCarried;
    }

    public int GetLargestAmountOfCaloriesCarriedByThreeElves()
    {
        return elves
            .OrderByDescending(p => p.TotalFoodCaloriesCarried)
            .Take(3)
            .Sum(p => p.TotalFoodCaloriesCarried);
    }

    private void PreComputeTotalCaloriesCarriedByElf(string[] input)
    {
        foreach (var line in input)
        {
            if (line == string.Empty)
            {
                elves.Add(new Elf());
            }
            else
            {
                elves[^1].TotalFoodCaloriesCarried += int.Parse(line);
            }
        }
    }
}