namespace AdventOfCode2022.December7
{
    public class FileSystem
    {
        public int TotalDiskSpace { get; set; }

        public Directory RootDirectory { get; set; } = new Directory { Name = "/" };
    }
}
