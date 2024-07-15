namespace HW_ParallelTasks
{
    public class FileCollectionHandler : IFileCollectionHandler
    {
        public string FilesDirectory { get; set; }

        private IFileReader FileReader;

        public string[]? GetFiles()
        {
            return Directory.GetFiles(FilesDirectory);
        }

        public FileCollectionHandler(string filesDirectory, IFileReader fileReader)
        {
            FilesDirectory = filesDirectory;
            FileReader = fileReader;
        }

        public async Task<int> ReadAllFilesAndCountSpaces()
        {
            List<Task<int>> paralleltasks = new List<Task<int>>();
            foreach (var filePath in GetFiles())
            {
                paralleltasks.Add(FileReader.ReadFileAndCountSpaces(filePath));
            }
            int[] SpacesCountArr = await Task.WhenAll(paralleltasks);
            return SpacesCountArr.Sum();
        }
    }
}
