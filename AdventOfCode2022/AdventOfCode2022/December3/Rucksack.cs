namespace AdventOfCode2022.December3
{
    public class Rucksack
    {
        public string Compartment1 { get; set; }

        public string Compartment2 { get; set; }

        public char[] FindCompartmentLoadingErrors()
        {
            return Compartment1.Intersect(Compartment2).ToArray();
        }

        public override string ToString()
        {
            return Compartment1 + Compartment2;
        }

        public static Rucksack FromInput(string input)
        {
            return new Rucksack
            {
                Compartment1 = input[..(input.Length / 2)],
                Compartment2 = input[(input.Length / 2)..],
            };
        }
    }
}
