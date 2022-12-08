using System.Text.Json.Serialization;

namespace AdventOfCode2022.December7
{
    public class Directory
    {
        public string Name { get; set; }

        [JsonIgnore]
        public Directory ParentDirectory { get; set; }

        public Dictionary<string, Directory> SubDirectories { get; set; } = new Dictionary<string, Directory>();

        public List<File> Files { get; set; } = new List<File> { };
    }
}
