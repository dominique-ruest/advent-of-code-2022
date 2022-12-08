namespace AdventOfCode2022.December7
{
    public class CommandShell
    {
        private readonly FileSystem fileSystem;

        public CommandShell(FileSystem fileSystem)
        {
            this.fileSystem = fileSystem;
            CurrentDirectory = fileSystem.RootDirectory;
        }

        public Directory CurrentDirectory { get; set; }

        public void ChangeDirectory(string directoryName)
        {
            CurrentDirectory = CurrentDirectory.SubDirectories[directoryName];
        }

        public void MoveToParentDirectory()
        {
            CurrentDirectory = CurrentDirectory.ParentDirectory ?? fileSystem.RootDirectory;
        }
        public void MoveToRootDirectory()
        {
            CurrentDirectory = fileSystem.RootDirectory;
        }

    }
}
