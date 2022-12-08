namespace AdventOfCode2022.December7
{

    public class Day7Program
    {
        public const int UPDATE_SIZE = 30000000;
        public static void Run()
        {
            var fileSystem = new FileSystem { TotalDiskSpace = 70000000 };
            var commandShell = new CommandShell(fileSystem);

            var inputs = System.IO.File.ReadAllLines("December7/input.txt");

            DiscoverFileSystem(commandShell, inputs);

            // PART 1
            var totalSizeOfDirectoriesOfAtMostXSize = 0;
            var totalUsedSpace = ComputeDirectorySize(fileSystem.RootDirectory, (directory, size) =>
            {
                if (size < 100000)
                {
                    totalSizeOfDirectoriesOfAtMostXSize += size;
                }
            });

            Console.WriteLine($"Total size: {totalSizeOfDirectoriesOfAtMostXSize}");

            // PART 2
            var remainingSpace = fileSystem.TotalDiskSpace - totalUsedSpace;
            var spaceToFreeUp = UPDATE_SIZE - remainingSpace;
            var smallestFolderSizeToFreeUpSpace = int.MaxValue;
            _ = ComputeDirectorySize(fileSystem.RootDirectory, (directory, size) =>
            {
                if (size > spaceToFreeUp && size < smallestFolderSizeToFreeUpSpace)
                {
                    smallestFolderSizeToFreeUpSpace = size;
                }
            });

            Console.WriteLine($"Smallest directory size to delete: {smallestFolderSizeToFreeUpSpace}");
        }

        public static int ComputeDirectorySize(Directory directory, Action<Directory, int> onDirectorySizeComputed)
        {
            var directorySize = directory.Files.Sum(p => p.Size)
                + directory.SubDirectories.Values.Sum(p => ComputeDirectorySize(p, onDirectorySizeComputed));

            onDirectorySizeComputed(directory, directorySize);

            return directorySize;
        }

        /// <summary>
        /// Build the file system graph from the input
        /// </summary>
        /// <param name="commandShell"></param>
        /// <param name="inputs"></param>
        private static void DiscoverFileSystem(CommandShell commandShell, string[] inputs)
        {
            var currentIndex = 0;
            while (currentIndex < inputs.Length)
            {
                if (inputs[currentIndex] == "$ cd /")
                {
                    commandShell.MoveToRootDirectory();
                }
                else if (inputs[currentIndex] == "$ cd ..")
                {
                    commandShell.MoveToParentDirectory();
                }
                else if (inputs[currentIndex].StartsWith("$ cd"))
                {
                    var directory = inputs[currentIndex].Split(' ').Last();
                    commandShell.ChangeDirectory(directory);
                }
                else if (inputs[currentIndex] == "$ ls")
                {
                    var shouldAddDiscoveredDirectoriesAndFilesToFileSystem =
                        commandShell.CurrentDirectory.Files.Count == 0 && commandShell.CurrentDirectory.SubDirectories.Count == 0;

                    while (currentIndex + 1 < inputs.Length && !inputs[currentIndex + 1].StartsWith("$"))
                    {
                        currentIndex++;

                        if (shouldAddDiscoveredDirectoriesAndFilesToFileSystem)
                        {
                            var listCommandResult = inputs[currentIndex].Split(" ");
                            if (listCommandResult[0] == "dir")
                            {
                                var directoryName = listCommandResult[1];
                                commandShell.CurrentDirectory.SubDirectories.Add(directoryName, new Directory { Name = directoryName, ParentDirectory = commandShell.CurrentDirectory });
                            }
                            else
                            {
                                var fileSize = int.Parse(listCommandResult[0]);
                                var fileName = listCommandResult[1];
                                commandShell.CurrentDirectory.Files.Add(new File { Name = fileName, Size = fileSize });
                            }
                        }
                    }
                }

                currentIndex++;
            }
        }
    }
}
